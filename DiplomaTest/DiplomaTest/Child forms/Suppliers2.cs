using DiplomaTest.Secondary_forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DiplomaTest.Child_forms
{
    public partial class Suppliers2 : Form
    {
        #region Variables

        //DB variables
        private readonly string connectionString = @"Server=tcp:ubicakrovi.database.windows.net,1433;Initial Catalog=DiplomaTest;Persist Security Info=False;User ID=firetruck;Password=74Rjcnzy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection connection;
        private SqlDataReader reader = null;
        private string query;
        private readonly string defaultQuery = "Select * from Suppliers";

        #endregion Variables


        //Constructor
        public Suppliers2()
        {
            InitializeComponent();
        }


        #region Methods

        //Form load
        private void Suppliers_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                RefreshSuppliers(defaultQuery);
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
        public void RefreshSuppliers(string query)
        {
            string SqlText = query;
            SqlDataAdapter da = new SqlDataAdapter(SqlText, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Suppliers");
            dataGridViewSuppliers.DataSource = ds.Tables["Suppliers"].DefaultView;
        }


        //Search
        private void SearchSuppliers()
        {
            connection.Open();
            int count = 0;
            query = $"select * from Suppliers where ";

            if (string.IsNullOrEmpty(textBoxUNP.Text) && string.IsNullOrEmpty(textBoxName.Text))
            {
                RefreshSuppliers(defaultQuery);
            }

            if (!string.IsNullOrEmpty(textBoxUNP.Text))
            {
                query += $" UNP like N'%{textBoxUNP.Text}%'";
                count++;
            }
            if (!string.IsNullOrEmpty(textBoxName.Text))
            {
                if (count > 0)
                {
                    query += $" and Name like N'%{textBoxName.Text}%'";
                }
                else
                {
                    query += $" Name like N'%{textBoxName.Text}%'";
                }
            }
            if (query != "select * from Suppliers where ")
            {
                RefreshSuppliers(query);
            }
            connection.Close();
        }

        private void dataGridViewSuppliers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewSupplierForm supplierViewForm = new ViewSupplierForm(Convert.ToInt32(dataGridViewSuppliers.Rows[dataGridViewSuppliers.CurrentCell.RowIndex].Cells[0].Value));
            supplierViewForm.Show();
        }


        //------------------------------TextChanged------------------------------
        
        
        private void textBoxUNP_TextChanged(object sender, EventArgs e)
        {
            SearchSuppliers();
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            SearchSuppliers();
        }
        private void textBoxWebsite_TextChanged(object sender, EventArgs e)
        {
            SearchSuppliers();
        }
        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
           SearchSuppliers();
        }
        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            SearchSuppliers();
        }
        #endregion
    }
}
