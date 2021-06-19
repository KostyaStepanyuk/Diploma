using DiplomaTest.Secondary_forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

#pragma warning disable IDE1006 // Подавить проверку стилей именования

namespace DiplomaTest.Child_froms
{
    public partial class Suppliers : Form
    {
        #region Variables

        //DB variables
        private readonly string connectionString = @"Server=tcp:ubicakrovi.database.windows.net,1433;Initial Catalog=DiplomaTest;Persist Security Info=False;User ID=firetruck;Password=74Rjcnzy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection connection;
        private SqlDataReader reader = null;
        private SqlCommand cmd;
        private string query;
        private readonly string defaultQuery = "Select * from Suppliers";
        private string currentSupplierUNP;

        private enum DataMode
        {
            Add,
            Edit,
            Delete,
            View
        }
        private DataMode dataMode = new DataMode();

        #endregion


        //Constructor
        public Suppliers()
        {
            InitializeComponent();
        }

        #region Methods


        //Update dataGridView info
        public void RefreshSuppliers(string query)
        {
            string SqlText = query;
            SqlDataAdapter da = new SqlDataAdapter(SqlText, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Suppliers");
            dataGridViewSuppliers.DataSource = ds.Tables["Suppliers"].DefaultView;
        }


        //dataGridView Cell Click
        private void dataGridViewSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = dataGridViewSuppliers.CurrentCell.RowIndex;
            SelectUser(rowID);
        }


        //Form load
        private void Suppliers_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                dataMode = DataMode.View;
                RefreshSuppliers(defaultQuery);
                SelectUser(0);
                connection.Close();
            }
            catch (Exception exception)
            {
                AlertForm alert = new AlertForm();
                alert.showAlert(exception.Message, AlertForm.alertType.Error);
            }
        }


        //Buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditViewSupplierForm addEditForm = new AddEditViewSupplierForm(AddEditViewSupplierForm.DataMode.Add, currentSupplierUNP);
            addEditForm.Show();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddEditViewSupplierForm addEditForm = new AddEditViewSupplierForm(AddEditViewSupplierForm.DataMode.Edit, currentSupplierUNP);
            addEditForm.Show();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteUser();
            SelectUser(0);
        }
        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            RefreshSuppliers(defaultQuery);
            SelectUser(0);
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            AddEditViewSupplierForm addEditForm = new AddEditViewSupplierForm(AddEditViewSupplierForm.DataMode.View, currentSupplierUNP);
            addEditForm.Show();
        }

        //Independent methods 
        private void DeleteUser()
        {
            int count = 0;
            connection.Open();
            query = $"Delete from Suppliers where";
            if (!string.IsNullOrEmpty(textBoxUNP.Text))
            {
                query += $" Suppliers.UNP = N'{textBoxUNP.Text}'";
                count++;
            }
            if (!string.IsNullOrEmpty(textBoxName.Text))
            {
                if (count > 0)
                {
                    query += $" and Suppliers.Name = N'{textBoxName.Text}'";
                }
                else
                {
                    query += $" Suppliers.Name = N'{textBoxName.Text}'";
                    count++;
                }
            }
            if (!string.IsNullOrEmpty(textBoxWebsite.Text))
            {
                if (count > 0)
                {
                    query += $" and Suppliers.Website = N'{textBoxWebsite.Text}'";
                }
                else
                {
                    query += $" Suppliers.Website = N'{textBoxWebsite.Text}'";
                    count++;
                }
            }
            if (!string.IsNullOrEmpty(textBoxPhoneNumber.Text))
            {
                if (count > 0)
                {
                    query += $" and Suppliers.PhoneNumber = N'{textBoxPhoneNumber.Text}'";
                }
                else
                {
                    query += $" Suppliers.PhoneNumber = N'{textBoxPhoneNumber.Text}'";
                    count++;
                }
            }
            if (!string.IsNullOrEmpty(textBoxAddress.Text))
            {
                if (count > 0)
                {
                    query += $" and Suppliers.Address = N'{textBoxAddress.Text}'";
                }
                else
                {
                    query += $" Suppliers.Address = N'{textBoxAddress.Text}'";
                }
            }
            if (!string.IsNullOrEmpty(textBoxEmail.Text))
            {
                if (count > 0)
                {
                    query += $" and Suppliers.Email = N'{textBoxEmail.Text}'";
                }
                else
                {
                    query += $" Suppliers.Email = N'{textBoxEmail.Text}'";
                }
            }
            if (query != "Delete from Suppliers where")
            {
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                reader.Close();
                RefreshSuppliers(defaultQuery);
            }
            connection.Close();
        }
        private void SelectUser(int rowID)
        {
            if (dataGridViewSuppliers.RowCount < 1)
            {
                return;
            }
            currentSupplierUNP = dataGridViewSuppliers.Rows[rowID].Cells[0].Value.ToString();
            textBoxUNP.Text = dataGridViewSuppliers.Rows[rowID].Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewSuppliers.Rows[rowID].Cells[1].Value.ToString();
            textBoxWebsite.Text = dataGridViewSuppliers.Rows[rowID].Cells[2].Value.ToString();
            textBoxPhoneNumber.Text = dataGridViewSuppliers.Rows[rowID].Cells[3].Value.ToString();
            textBoxAddress.Text = dataGridViewSuppliers.Rows[rowID].Cells[4].Value.ToString();
            textBoxEmail.Text = dataGridViewSuppliers.Rows[rowID].Cells[5].Value.ToString();
        }


        #endregion
    }
}
