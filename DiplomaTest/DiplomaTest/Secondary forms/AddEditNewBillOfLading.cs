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
    public partial class AddEditNewBillOfLading : Form
    {
        #region Variables

        //DB variables
        private readonly string connectionString = @"Server=tcp:ubicakrovi.database.windows.net,1433;Initial Catalog=DiplomaTest;Persist Security Info=False;User ID=firetruck;Password=74Rjcnzy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection connection;
        private SqlDataReader reader = null;
        private SqlCommand cmd;
        private string query;
        private readonly string defaultQuery = "Select * from BillsOfLadingView where Order_Id = ";
        int currentCustomerID;
        int oldQuantity = 0;

        private readonly Color  Black = Color.FromArgb(30, 39, 46),
                                DarkLightGrey = Color.FromArgb(85, 94, 101),
                                Gray = Color.FromArgb(128, 142, 155),
                                LightGray = Color.FromArgb(210, 218, 226),
                                Green = Color.FromArgb(5, 196, 107),
                                Cyan = Color.FromArgb(52, 231, 228),
                                Red = Color.FromArgb(243, 31, 77),
                                White = Color.FromArgb(250, 242, 243);


        #endregion Variables

        public AddEditNewBillOfLading(int currentCustomerID)
        {
            InitializeComponent();
            this.currentCustomerID = currentCustomerID;
        }

        private void FillBillOfLading(int currentOrderID)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            query = $"Select * from OrdersViewSecondary where order_id = '{currentOrderID}'";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            List<ProductsForBillOfLading> output = new List<ProductsForBillOfLading>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string productName = reader.GetString(1);
                    int quantity = reader.GetInt32(4);
                    DateTime deliveryDate = reader.GetDateTime(8);
                    int orderID = currentOrderID;
                    int customerID = currentCustomerID;

                    ProductsForBillOfLading products1 = new ProductsForBillOfLading()
                    {
                        ProductName = productName,
                        Quantity = quantity,
                        DeliveryDate = deliveryDate,
                        OrderId = orderID,
                        CommodityExpertId = customerID
                    };
                    output.Add(products1);
                }
            }
            reader.Close();

            query = $"insert into Bills_of_lading (DeliveryDate, Order_ID, CommodityExpert_ID) values " +
                            $"('{output[0].DeliveryDate.Day + "-" + output[0].DeliveryDate.Month + "-" + output[0].DeliveryDate.Year}', {output[0].OrderId}, {output[0].CommodityExpertId})";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            reader.Close();

            query = "SELECT @@IDENTITY Bills_of_lading";
            cmd = new SqlCommand(query, connection);
            int id = Convert.ToInt32(cmd.ExecuteScalar());

            for (int i = 0; i < output.Count; i++)
            {
                query = $"Select Product_ID from Products where Name = N'{output[i].ProductName}'";
                cmd = new SqlCommand(query, connection);
                int productID = Convert.ToInt32(cmd.ExecuteScalar());

                query = $"insert into BillOfLading_information (BillOfLading_ID, Product_ID, Quantity) values " +
                            $"({id}, {productID}, {output[i].Quantity})";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                reader.Close();

                List<int> productIDs = new List<int>();

                //for (int i = 0; i < dataGridViewBillOfLading.RowCount; i++)
                //{
                //    query = $"Select Product_ID from Products where Name = N'{dataGridViewBillOfLading.Rows[i].Cells[1].Value}'";
                //    cmd = new SqlCommand(query, connection);
                //    productIDs.Add(Convert.ToInt32(cmd.ExecuteScalar()));
                //}

                //for (int i = 0; i < output.Count; i++)
                //{
                //    query = $"Select product_id from products where name = {output[i].ProductName}";
                //    cmd = new SqlCommand(query, connection);
                //    int productID = Convert.ToInt32(cmd.ExecuteScalar());
                query = $"Select count(*) from Remains where Product_ID = {productID}";
                cmd = new SqlCommand(query, connection);
                int buff = Convert.ToInt32(cmd.ExecuteScalar());
                if (buff == 0)
                {
                    query = $"Select ValueAddedRatio from Store_information";
                    cmd = new SqlCommand(query, connection);
                    double valueAddedRatio = Convert.ToDouble(cmd.ExecuteScalar());
                    valueAddedRatio = valueAddedRatio / 100 + 1;

                    query = $"Select Price from Products where Product_ID = {productID}";
                    cmd = new SqlCommand(query, connection);
                    int productPrice = Convert.ToInt32(cmd.ExecuteScalar());
                    double endPrice = productPrice * 1.1 * valueAddedRatio;

                    query = $"Insert into Remains (Product_ID, Quantity, Price) values ({productID}, {output[i].Quantity}, '{endPrice}')";
                    cmd = new SqlCommand(query, connection);
                    reader = cmd.ExecuteReader();
                    reader.Close();
                }
                else
                {
                    query = $"Select Quantity from Remains where Product_ID = {productID}";
                    cmd = new SqlCommand(query, connection);
                    int quantity = Convert.ToInt32(cmd.ExecuteScalar());

                    query = $"Update Remains set Quantity = {quantity + output[i].Quantity} where Product_ID = {productID}";
                    cmd = new SqlCommand(query, connection);
                    reader = cmd.ExecuteReader();
                    reader.Close();
                }
                //}
            }
            query = $"update Orders set Status = N'Доставлен' where Order_ID = {comboBoxOrders.Text}";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            reader.Close();
            connection.Close();
        }

        private void LoadOrders()
        {
            query = $"Select Order_ID from Orders where Status = N'В ожидании'";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBoxOrders.Items.Add(reader.GetInt32(0));
                }
            }
        }
        private void AddEditNewBillOfLading_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                LoadOrders();
                
                connection.Close();
                comboBoxOrders.SelectedIndex = 0;
                lblModeUserTitle.Text = "ТТН №" + dataGridViewBillOfLading.Rows[0].Cells[0].Value.ToString();
            }
            catch (Exception exception)
            {
                AlertForm alert = new AlertForm();
                alert.showAlert(exception.Message, AlertForm.alertType.Error);
            }
        }

        private void RefreshBillOfLading()
        {
            string SqlText = "Select * from BillsOfLadingSecondary where Order_ID = " + comboBoxOrders.Text;
            SqlDataAdapter da = new SqlDataAdapter(SqlText, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "BillsOfLadingSecondary");
            dataGridViewBillOfLading.DataSource = ds.Tables["BillsOfLadingSecondary"].DefaultView;
        }

        private void comboBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();

            query = $"select count(*) from Bills_of_lading where Order_ID = '{comboBoxOrders.Text}'";
            cmd = new SqlCommand(query, connection);
            int buff = Convert.ToInt32(cmd.ExecuteScalar());

            if (buff > 0)
            {
                RefreshBillOfLading();
            }
            else
            {
                FillBillOfLading(Convert.ToInt32(comboBoxOrders.Text));
                RefreshBillOfLading();
            }
            connection.Close();
        }

        private void dataGridViewBillOfLading_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                connection.Open();
                query = $"Select product_id from products where name = N'{dataGridViewBillOfLading.Rows[dataGridViewBillOfLading.CurrentCell.RowIndex].Cells[1].Value}'";
                cmd = new SqlCommand(query, connection);
                int productID = Convert.ToInt32(cmd.ExecuteScalar());

                query = $"Select Quantity from Remains where Product_ID = {productID}";
                cmd = new SqlCommand(query, connection);
                int quantityRemains = Convert.ToInt32(cmd.ExecuteScalar());

                if (Convert.ToInt32(dataGridViewBillOfLading.Rows[dataGridViewBillOfLading.CurrentCell.RowIndex].Cells[2].Value) != oldQuantity)
                {
                    int endQuantity = quantityRemains - (oldQuantity - Convert.ToInt32(dataGridViewBillOfLading.Rows[dataGridViewBillOfLading.CurrentCell.RowIndex].Cells[2].Value));
                    query = $"update BillOfLading_information set Quantity = {Convert.ToInt32(dataGridViewBillOfLading.Rows[dataGridViewBillOfLading.CurrentCell.RowIndex].Cells[2].Value)} where Product_ID = {productID} and BillOfLading_ID = {dataGridViewBillOfLading.Rows[dataGridViewBillOfLading.CurrentCell.RowIndex].Cells[0].Value}";
                    cmd = new SqlCommand(query, connection);
                    reader = cmd.ExecuteReader();
                    reader.Close();

                    query = $"update Remains set Quantity = {endQuantity} where Product_ID = {productID}";
                    cmd = new SqlCommand(query, connection);
                    reader = cmd.ExecuteReader();
                    reader.Close();
                }
                
                connection.Close();
            }
            catch (Exception exc)
            {
                AlertForm alert = new AlertForm();
                alert.showAlert(exc.Message, AlertForm.alertType.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxOrders.SelectedIndex != -1)
            {
                using (ProductsList productsList = new ProductsList(Convert.ToInt32(comboBoxOrders.Text)))
                {
                    if (productsList.ShowDialog() != DialogResult.Cancel)
                        RefreshBillOfLading();
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBillOfLading.RowCount == 0)
            {
                return;
            }

            connection.Open();

            query = $"Select Product_ID from Products where Name = N'{dataGridViewBillOfLading.Rows[dataGridViewBillOfLading.CurrentCell.RowIndex].Cells[1].Value}'";
            cmd = new SqlCommand(query, connection);
            int productID = Convert.ToInt32(cmd.ExecuteScalar());

            query = $"delete from BillOfLading_information where " +
                $"BillOfLading_ID = {dataGridViewBillOfLading.Rows[dataGridViewBillOfLading.CurrentCell.RowIndex].Cells[0].Value} and " +
                $"Product_ID = {productID}";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            reader.Close();

            query = $"Select Quantity from Remains where Product_ID = {productID}";
            cmd = new SqlCommand(query, connection);
            int quantityRemains = Convert.ToInt32(cmd.ExecuteScalar());

            quantityRemains -= Convert.ToInt32(dataGridViewBillOfLading.Rows[dataGridViewBillOfLading.CurrentCell.RowIndex].Cells[2].Value);

            query = $"update remains set Quantity = {quantityRemains} where Product_ID = {productID}";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            reader.Close();

            RefreshBillOfLading();
            connection.Close();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            AlertForm alert = new AlertForm();
            alert.showAlert("Успешно сохранено!", AlertForm.alertType.Success);
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

        private void dataGridViewBillOfLading_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldQuantity = Convert.ToInt32(dataGridViewBillOfLading.Rows[dataGridViewBillOfLading.CurrentCell.RowIndex].Cells[2].Value);
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
