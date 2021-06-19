using FontAwesome.Sharp;
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

namespace DiplomaTest.Secondary_forms
{
    public partial class ProductsList : Form
    {
        #region Variables

        //DB variables
        private readonly string connectionString = @"Server=tcp:ubicakrovi.database.windows.net,1433;Initial Catalog=DiplomaTest;Persist Security Info=False;User ID=firetruck;Password=74Rjcnzy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection connection;
        private SqlDataReader reader = null;
        private SqlCommand cmd;
        private string query;
        private readonly string defaultQuery = "Select * from Products where Supplier = ";
        int orderID;

        private readonly Color Black = Color.FromArgb(30, 39, 46),
                                DarkLightGrey = Color.FromArgb(85, 94, 101),
                                Gray = Color.FromArgb(128, 142, 155),
                                LightGray = Color.FromArgb(210, 218, 226),
                                Green = Color.FromArgb(5, 196, 107),
                                Cyan = Color.FromArgb(52, 231, 228),
                                Red = Color.FromArgb(243, 31, 77),
                                White = Color.FromArgb(250, 242, 243);


        #endregion Variables
        public ProductsList(int orderID)
        {
            InitializeComponent();
            this.orderID = orderID;
        }

        private void ProductsList_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                query = $"select Supplier_UNP from Orders where Order_id = '{orderID}'";
                cmd = new SqlCommand(query, connection);
                int supplierUNP = Convert.ToInt32(cmd.ExecuteScalar());

                query = $"select Name from Suppliers where UNP = '{supplierUNP}'";
                cmd = new SqlCommand(query, connection);
                string supplierName = cmd.ExecuteScalar().ToString();

                RefreshProducts(supplierName);
                connection.Close();
            }
            catch (Exception exception)
            {
                AlertForm alert = new AlertForm();
                alert.showAlert(exception.Message, AlertForm.alertType.Error);
            }
        }

        private void RefreshProducts(string supplierName)
        {
            string SqlText = $"Select * from ProductsView where SupplierName = N'{supplierName}'";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "ProductsView");
            dataGridViewProducts.DataSource = ds.Tables["ProductsView"].DefaultView;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();

            query = $"Select BillOfLading_ID from Bills_of_lading where order_ID = '{orderID}'";
            cmd = new SqlCommand(query, connection);
            int billOfLadingID = Convert.ToInt32(cmd.ExecuteScalar());

            query = $"Select Product_ID from Products where Name = N'{dataGridViewProducts.Rows[dataGridViewProducts.CurrentCell.RowIndex].Cells[2].Value}'";
            cmd = new SqlCommand(query, connection);
            int productID = Convert.ToInt32(cmd.ExecuteScalar());

            query = $"Select count(*) from BillOfLading_information where Product_ID = {productID} and BillOfLading_ID = {billOfLadingID}";
            cmd = new SqlCommand(query, connection);
            int buff = Convert.ToInt32(cmd.ExecuteScalar());

            if (buff <= 0)
            {
                query = $"insert into BillOfLading_information (BillOfLading_ID, Product_ID, Quantity) values ({billOfLadingID}, {productID}, 1)";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                reader.Close();

                query = $"Select count(*) from Remains where Product_ID = {productID}";
                cmd = new SqlCommand(query, connection);
                int buff2 = Convert.ToInt32(cmd.ExecuteScalar());
                if (buff2 == 0)
                {
                    query = $"Select ValueAddedRatio from Store_information";
                    cmd = new SqlCommand(query, connection);
                    double valueAddedRatio = Convert.ToDouble(cmd.ExecuteScalar());
                    valueAddedRatio = valueAddedRatio / 100 + 1;

                    query = $"Select Price from Products where Product_ID = {productID}";
                    cmd = new SqlCommand(query, connection);
                    int productPrice = Convert.ToInt32(cmd.ExecuteScalar());
                    double endPrice = productPrice * 1.1 * valueAddedRatio;

                    query = $"Insert into Remains (Product_ID, Quantity, Price) values ({productID}, 1, '{endPrice}')";
                    cmd = new SqlCommand(query, connection);
                    reader = cmd.ExecuteReader();
                    reader.Close();
                }
                else
                {
                    query = $"Select Quantity from Remains where Product_ID = {productID}";
                    cmd = new SqlCommand(query, connection);
                    int quantity = Convert.ToInt32(cmd.ExecuteScalar());

                    query = $"Update Remains set Quantity = {quantity + 1} where Product_ID = {productID}";
                    cmd = new SqlCommand(query, connection);
                    reader = cmd.ExecuteReader();
                    reader.Close();
                }
            }

            connection.Close();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #region WindowControl

        //Mouse leave
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Black;
            btnExit.IconColor = Red;
        }
        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Black;
        }

        

        private void btnMaximizeRestore_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizeRestore.BackColor = Black;
        }


        //Mouse Enter
        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Red;
            btnExit.IconColor = White;
        }
        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.BackColor = DarkLightGrey;
        }
        private void btnMaximizeRestore_MouseEnter(object sender, EventArgs e)
        {
            btnMaximizeRestore.BackColor = DarkLightGrey;
        }


        //Click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMaximizeRestore_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximizeRestore.IconChar = IconChar.WindowRestore;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximizeRestore.IconChar = IconChar.WindowMaximize;
            }
        }

        #endregion
    }
}
