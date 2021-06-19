using DiplomaTest.Secondary_forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DiplomaTest.Child_forms
{
    public partial class Products : Form
    {
        #region Variables

        //DB variables
        private readonly string connectionString = @"Server=tcp:ubicakrovi.database.windows.net,1433;Initial Catalog=DiplomaTest;Persist Security Info=False;User ID=firetruck;Password=74Rjcnzy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection connection;
        private SqlDataReader reader = null;
        private string query;
        private readonly string defaultQuery = "Select * from ProductsView";

        #endregion Variables


        //Constructor
        public Products()
        {
            InitializeComponent();
        }


        #region Methods

        //Form load
        private void Products_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                RefreshProducts(defaultQuery);
                LoadComboBoxes();
                connection.Close();
            }
            catch (Exception exception)
            {
                AlertForm alert = new AlertForm();
                alert.showAlert(exception.Message, AlertForm.alertType.Error);
            }
        }


        //------------------------------Independent methods------------------------------------

        //Update dataGridView info
        public void RefreshProducts(string query)
        {
            string SqlText = query;
            SqlDataAdapter da = new SqlDataAdapter(SqlText, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "ProductsView");
            dataGridViewProducts.DataSource = ds.Tables["ProductsView"].DefaultView;
        }


        //Load comboBoxes
        private void LoadComboBoxes()
        {
            query = $"Select Name from Suppliers";
            SqlCommand command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBoxSupplier.Items.Add(reader.GetString(0));
                }
            }
            reader.Close();
            query = $"Select Name from Departments";
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBoxDepartment.Items.Add(reader.GetString(0));
                }
            }
            reader.Close();
        }

        //Search
        private void SearchProducts()
        {
            connection.Open();
            int count = 0;
            query = $"select * from ProductsView where ";

            if (string.IsNullOrEmpty(textBoxArticle.Text) && string.IsNullOrEmpty(textBoxBarcode.Text) && string.IsNullOrEmpty(textBoxName.Text) && string.IsNullOrEmpty(comboBoxDepartment.Text) && string.IsNullOrEmpty(comboBoxSupplier.Text))
            {
                RefreshProducts(defaultQuery);
            }

            if (!string.IsNullOrEmpty(textBoxArticle.Text))
            {
                query += $" Article like N'%{textBoxArticle.Text}%'";
                count++;
            }
            if (!string.IsNullOrEmpty(textBoxBarcode.Text))
            {
                if (count > 0)
                {
                    query += $" and Barcode like N'%{textBoxBarcode.Text}%'";
                }
                else
                {
                    query += $" Barcode like N'%{textBoxBarcode.Text}%'";
                    count++;
                }
            }
            if (!string.IsNullOrEmpty(textBoxName.Text))
            {
                if (count > 0)
                {
                    query += $" and ProductName like N'%{textBoxName.Text}%'";
                }
                else
                {
                    query += $" ProductName like N'%{textBoxName.Text}%'";
                    count++;
                }
            }
            if (!string.IsNullOrEmpty(comboBoxDepartment.Text))
            {
                if (count > 0)
                {
                    query += $" and DepartmentName like N'%{comboBoxDepartment.Text}%'";
                }
                else
                {
                    query += $" DepartmentName like N'%{comboBoxDepartment.Text}%'";
                    count++;
                }
            }
            if (!string.IsNullOrEmpty(comboBoxSupplier.Text))
            {
                if (count > 0)
                {
                    query += $" and SupplierName like N'%{comboBoxSupplier.Text}%'";
                }
                else
                {
                    query += $" SupplierName like N'%{comboBoxSupplier.Text}%'";
                }
            }
            if (query != "select * from ProductsView where ")
            {
                RefreshProducts(query);
            }
            connection.Close();
        }




        private void dataGridViewProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewProductForm productViewForm = new ViewProductForm(Convert.ToInt32(dataGridViewProducts.Rows[dataGridViewProducts.CurrentCell.RowIndex].Cells[0].Value));
            productViewForm.Show();
        }


        //------------------------------TextChanged------------------------------
        private void textBoxArticle_TextChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }
        private void textBoxBarcode_TextChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }
        private void comboBoxDepartment_TextChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }
        private void comboBoxSupplier_TextChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }

        #endregion
    }
}
