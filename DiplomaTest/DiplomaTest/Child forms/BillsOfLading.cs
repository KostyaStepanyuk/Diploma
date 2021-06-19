using DiplomaTest.Secondary_forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DiplomaTest.Child_forms
{
    public partial class BillsOfLading : Form
    {
        #region Variables

        //DB variables
        private readonly string connectionString = @"Server=tcp:ubicakrovi.database.windows.net,1433;Initial Catalog=DiplomaTest;Persist Security Info=False;User ID=firetruck;Password=74Rjcnzy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection connection;
        private SqlDataReader reader = null;
        private SqlCommand cmd;
        private string query;
        private readonly string defaultQuery = "Select * from BillsOfLadingMain";
        private int commodityExpertID;


        #endregion Variables
        public BillsOfLading(int commodityExpertID)
        {
            InitializeComponent();
            this.commodityExpertID = commodityExpertID;
        }

        //Update dataGridView info
        public void RefreshBillsOfLading(string query)
        {
            string SqlText = query;
            SqlDataAdapter da = new SqlDataAdapter(SqlText, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "BillsOfLadingMain");
            dataGridViewBillsOfLading.DataSource = ds.Tables["BillsOfLadingMain"].DefaultView;
        }

        private void BillsOfLading_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                RefreshBillsOfLading(defaultQuery);
                connection.Close();
            }
            catch (Exception exception)
            {
                AlertForm alert = new AlertForm();
                alert.showAlert(exception.Message, AlertForm.alertType.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            query = $"Select count(*) from Orders where Status = N'В ожидании'";
            cmd = new SqlCommand(query, connection);
            int buff = Convert.ToInt32(cmd.ExecuteScalar());
            if (buff > 0)
            {
                AddEditNewBillOfLading addNew = new AddEditNewBillOfLading(commodityExpertID);
                addNew.Show();
            }
            else
            {
                AlertForm alert = new AlertForm();
                alert.showAlert("В базе отсутсвуют заказы, ожидающие подтверждения!", AlertForm.alertType.Info);
            }
            connection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBillsOfLading.RowCount == 0)
            {
                return;
            }

            connection.Open();

            List<ProductsForRemains> output = new List<ProductsForRemains>();
            query = $"Select Product_ID, Quantity from BillOfLading_information where BillOfLading_ID = {dataGridViewBillsOfLading.Rows[dataGridViewBillsOfLading.CurrentCell.RowIndex].Cells[0].Value}";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ProductsForRemains products = new ProductsForRemains
                    {
                        Id = reader.GetInt32(0),
                        Quantity = reader.GetInt32(1)
                    };
                    output.Add(products);
                }
            }
            reader.Close();

            foreach (ProductsForRemains product in output)
            {
                query = $"Select Quantity from Remains where Product_ID = {product.Id}";
                cmd = new SqlCommand(query, connection);
                int quantityRemains = Convert.ToInt32(cmd.ExecuteScalar());


                query = $"Update Remains set Quantity = {quantityRemains - product.Quantity} where Product_ID = {product.Id}";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                reader.Close();
            }
            query = $"Delete from Bills_of_lading where Order_ID = {dataGridViewBillsOfLading.Rows[dataGridViewBillsOfLading.CurrentCell.RowIndex].Cells[1].Value}";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            reader.Close();

            query = $"Update Orders set Status = N'В ожидании' where Order_ID = {dataGridViewBillsOfLading.Rows[dataGridViewBillsOfLading.CurrentCell.RowIndex].Cells[1].Value}";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            reader.Close();

           

            RefreshBillsOfLading(defaultQuery);
            connection.Close();
        }

        private void dataGridViewBillsOfLading_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Secondary_forms.BillsOfLadingViewEdit billsOfLadingForm = new Secondary_forms.BillsOfLadingViewEdit(Convert.ToInt32(dataGridViewBillsOfLading.Rows[dataGridViewBillsOfLading.CurrentCell.RowIndex].Cells[0].Value), BillsOfLadingViewEdit.DataMode.View);
            billsOfLadingForm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Secondary_forms.BillsOfLadingViewEdit billsOfLadingForm = new Secondary_forms.BillsOfLadingViewEdit(Convert.ToInt32(dataGridViewBillsOfLading.Rows[dataGridViewBillsOfLading.CurrentCell.RowIndex].Cells[0].Value), BillsOfLadingViewEdit.DataMode.Edit);
            billsOfLadingForm.Show();
        }
    }
}
