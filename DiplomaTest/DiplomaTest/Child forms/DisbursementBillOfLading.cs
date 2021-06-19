using DiplomaTest.Secondary_forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaTest.Child_forms
{
    public partial class DisbursementBillOfLading : Form
    {
        #region Variables

        //DB variables
        private readonly string connectionString = @"Server=tcp:ubicakrovi.database.windows.net,1433;Initial Catalog=DiplomaTest;Persist Security Info=False;User ID=firetruck;Password=74Rjcnzy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection connection;
        private SqlDataReader reader = null;
        private SqlCommand cmd;
        private string query;
        private readonly string defaultQuery = "Select * from DisbursementBOLView";
        private int commodityExpertID;


        #endregion Variables
        public DisbursementBillOfLading(int commodityExpertID)
        {
            InitializeComponent();
            this.commodityExpertID = commodityExpertID;
        }

        public void RefreshDisbursementBillsOfLading(string query)
        {
            string SqlText = query;
            SqlDataAdapter da = new SqlDataAdapter(SqlText, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "DisbursementBOLView");
            dataGridViewDisbursementBillsOfLading.DataSource = ds.Tables["DisbursementBOLView"].DefaultView;
        }

        private void DisbursementBillOfLading_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                RefreshDisbursementBillsOfLading(defaultQuery);
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
            AddEditNewDisbursementBillOfLading addNew = new AddEditNewDisbursementBillOfLading(commodityExpertID);
            addNew.ShowDialog();

            if (addNew.DialogResult != DialogResult.Cancel)
            {
                RefreshDisbursementBillsOfLading(defaultQuery);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewDisbursementBillsOfLading.RowCount == 0)
            {
                return;
            }
            connection.Open();

            List<ProductsForRemains> output = new List<ProductsForRemains>();
            query = $"Select Product_ID, Quantity from DisbursementBOL_information where DBOL_ID = {dataGridViewDisbursementBillsOfLading.Rows[dataGridViewDisbursementBillsOfLading.CurrentCell.RowIndex].Cells[0].Value}";
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


                query = $"Update Remains set Quantity = {quantityRemains + product.Quantity} where Product_ID = {product.Id}";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                reader.Close();
            }
            query = $"Delete from DisbursementBOL where DisbursementBOL_ID = {dataGridViewDisbursementBillsOfLading.Rows[dataGridViewDisbursementBillsOfLading.CurrentCell.RowIndex].Cells[0].Value}";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            reader.Close();

            RefreshDisbursementBillsOfLading(defaultQuery);
            connection.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            connection.Open();

            AddEditNewDisbursementBillOfLading addNew = new AddEditNewDisbursementBillOfLading(commodityExpertID, Convert.ToInt32(dataGridViewDisbursementBillsOfLading.Rows[dataGridViewDisbursementBillsOfLading.CurrentCell.RowIndex].Cells[0].Value));
            addNew.ShowDialog();

            if (addNew.DialogResult != DialogResult.Cancel)
            {
                RefreshDisbursementBillsOfLading(defaultQuery);
            }

            connection.Close();
        }

        private void dataGridViewDisbursementBillsOfLading_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
