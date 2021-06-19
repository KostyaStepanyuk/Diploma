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
    public partial class NewOrder : Form
    {
        #region Variables

        //DB variables
        private readonly string connectionString = @"Server=tcp:ubicakrovi.database.windows.net,1433;Initial Catalog=DiplomaTest;Persist Security Info=False;User ID=firetruck;Password=74Rjcnzy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection connection;
        private SqlDataReader reader = null;
        private SqlCommand cmd;
        private string query;
        private readonly int customerID;
        private string currentSupplierUNP = null;
        private string supplierName;
        private int currentOrderID;

        private readonly Color  Black = Color.FromArgb(30, 39, 46),
                                DarkLightGrey = Color.FromArgb(85, 94, 101),
                                Red = Color.FromArgb(243, 31, 77),
                                White = Color.FromArgb(250, 242, 243);

        public enum DataMode
        {
            Add,
            Edit
        }
        private DataMode dataMode = new DataMode();

        #endregion Variables

        #region Methods


        public NewOrder(int customerID, DataMode dataMode)
        {
            InitializeComponent();
            this.customerID = customerID;
            this.dataMode = dataMode;
        }

        public NewOrder(int customerID, DataMode dataMode, string supplierName)
        {
            InitializeComponent();
            this.customerID = customerID;
            this.dataMode = dataMode;
            this.supplierName = supplierName;
        }

        //Update dataGridView info
        public void RefreshProducts()
        {
            string SqlText = $"Select * from ProductsView where SupplierName = N'{comboBoxSupplier.Text}'";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "ProductsView");
            dataGridViewProducts.DataSource = ds.Tables["ProductsView"].DefaultView;
        }
        

        private void NewOrder_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                LoadSuppliers();
            }
            catch (Exception exception)
            {
                AlertForm alert = new AlertForm();
                alert.showAlert(exception.Message, AlertForm.alertType.Error);
            }
        }

        private void LoadSuppliers()
        {
            connection.Open();
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
            connection.Close();
            if (supplierName != null)
            {
                comboBoxSupplier.SelectedIndex = comboBoxSupplier.Items.IndexOf(supplierName);
            }
        }

        private void btnAddAllProducts_Click(object sender, EventArgs e)
        { 
            for (int i = 0; i < dataGridViewProducts.RowCount; i++)
            {
                connection.Open();
                query = $"select Product_ID from Products where Name = N'{dataGridViewProducts.Rows[i].Cells[2].Value}' and Supplier_UNP = '{currentSupplierUNP}'";
                cmd = new SqlCommand(query, connection);
                int productID = Convert.ToInt32(cmd.ExecuteScalar());
                query = $"select count(*) from order_information where Product_ID = {productID} and order_ID = {currentOrderID}";
                cmd = new SqlCommand(query, connection);
                int buff = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();
                if (buff < 1)
                {
                    AddProductToOrder(productID);
                    RefreshNewOrder(currentOrderID);
                }
            }
            RefreshNewOrder(currentOrderID);
        }

        private void comboBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            query = $"Select UNP from Suppliers where Name = N'{comboBoxSupplier.Text}'";
            cmd = new SqlCommand(query, connection);
            currentSupplierUNP = cmd.ExecuteScalar().ToString();
            RefreshProducts();
            connection.Close();
            RefreshOrders();
        }

        private void RefreshNewOrder(int orderID)
        {
            string SqlText = $"Select * from OrdersViewSecondary where Order_ID = {orderID}";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "OrdersViewSecondary");
            dataGridViewNewOrder.DataSource = ds.Tables["OrdersViewSecondary"].DefaultView;
        }

        private void CreateNewOrder()
        {
            connection.Open();
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            query = $"Insert into Orders (User_ID, OrderDate, DeliveryDate, Status, Supplier_UNP) values ({customerID}, '{ dateTime.Year + "-" + dateTime.Month + "-" + dateTime.Day}', '{rjDatePicker1.Value.Year + "-" + rjDatePicker1.Value.Month + "-" + rjDatePicker1.Value.Day}', N'В ожидании', '{currentSupplierUNP}')";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            reader.Close();
            connection.Close();
        }

        private void RefreshOrders()
        {
            if (dataMode == DataMode.Edit)
            {
                connection.Open();
                query = $"select Order_ID from Orders where Supplier_UNP = '{currentSupplierUNP}' and Status = N'В ожидании'";
                cmd = new SqlCommand(query, connection);
                currentOrderID = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();
                RefreshNewOrder(currentOrderID);
            }
            if (dataMode == DataMode.Add)
            {
                CreateNewOrder();
                connection.Open();
                query = "SELECT IDENT_CURRENT ('Orders')";
                cmd = new SqlCommand(query, connection);
                currentOrderID = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();
                RefreshNewOrder(currentOrderID);
            }
        }

        private void AddProductToOrder(int productID)
        {
            connection.Open();
            query = $"insert into order_information (Order_ID, Product_ID, Quantity) values ('{currentOrderID}', '{productID}', 1)";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            reader.Close();
            connection.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentCell.Selected == true)
            {
                connection.Open();
                query = $"select Product_ID from products where Name = N'{dataGridViewProducts.Rows[dataGridViewProducts.CurrentCell.RowIndex].Cells[2].Value}'";
                cmd = new SqlCommand(query, connection);
                int productID = Convert.ToInt32(cmd.ExecuteScalar());
                query = $"select count(*) from order_information where Product_ID = {productID} and order_ID = {currentOrderID}";
                cmd = new SqlCommand(query, connection);
                int buff = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();
                if (buff > 0)
                {
                    AlertForm alert = new AlertForm();
                    alert.showAlert("Такой продукт уже есть в этом заказе!", AlertForm.alertType.Error);
                }
                else
                {
                    AddProductToOrder(productID);
                    RefreshNewOrder(currentOrderID);
                }
            }
        }

        private void dataGridViewNewOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            connection.Open();

            query = $"Select product_ID from Products where name = N'{dataGridViewNewOrder.Rows[dataGridViewNewOrder.CurrentCell.RowIndex].Cells[0].Value}' and supplier_UNP = '{currentSupplierUNP}'";
            cmd = new SqlCommand(query, connection);
            int productID = Convert.ToInt32(cmd.ExecuteScalar());

            query = $"update Order_information set Quantity = {dataGridViewNewOrder.Rows[dataGridViewNewOrder.CurrentCell.RowIndex].Cells[3].Value} where Order_ID = {currentOrderID} and product_ID = {productID}";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            reader.Close();
            connection.Close();
            //RefreshNewOrder(currentOrderID);
        }


        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            connection.Open();
            query = $"select product_id from products where name = N'{dataGridViewNewOrder.Rows[dataGridViewNewOrder.CurrentCell.RowIndex].Cells[0].Value}' and supplier_unp = '{currentSupplierUNP}'";
            cmd = new SqlCommand(query, connection);
            int productID = Convert.ToInt32(cmd.ExecuteScalar());
            query = $"Delete from Order_information where Order_ID = '{currentOrderID}' and Product_ID = '{productID}'";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            reader.Close();
            connection.Close();
            RefreshNewOrder(currentOrderID);
        }

        private void btnRemoveAllProducts_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewNewOrder.RowCount; i++)
            {
                connection.Open();
                query = $"select Product_ID from Products where Name = N'{dataGridViewNewOrder.Rows[i].Cells[0].Value}' and Supplier_UNP = '{currentSupplierUNP}'";
                cmd = new SqlCommand(query, connection);
                int productID = Convert.ToInt32(cmd.ExecuteScalar());
                query = $"Delete from Order_information where Order_ID = '{currentOrderID}' and Product_ID = '{productID}'";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                reader.Close();
                connection.Close();
            }
            RefreshNewOrder(currentOrderID);
        }

        #endregion

        #region WindowControl

        //Mouse Leave
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
            Form newForm = Application.OpenForms[0];
            newForm.Show();
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
