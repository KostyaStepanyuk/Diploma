using DiplomaTest.Secondary_forms;
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

namespace DiplomaTest.Main_forms
{
    public partial class CashierMenu : Form
    {

        #region Variables

        //DB variables
        private readonly string connectionString = @"Server=tcp:ubicakrovi.database.windows.net,1433;Initial Catalog=DiplomaTest;Persist Security Info=False;User ID=firetruck;Password=74Rjcnzy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection connection;
        private SqlDataReader reader = null;
        private SqlCommand cmd;
        private string query;
        private readonly string defaultQuery = "select * from ProductsForCashier";
        private readonly int customerID;
        private string currentSupplierUNP = null;
        private string supplierName;
        private int currentOrderID;

        private readonly Color Black = Color.FromArgb(30, 39, 46),
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
        public CashierMenu()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            bool isAllowedToAdd = true;
            for (int i = 0; i < dataGridViewNewCheque.RowCount; i++)
            {
                if (dataGridViewNewCheque.Rows[i].Cells[0].Value == dataGridViewProducts.Rows[dataGridViewProducts.CurrentCell.RowIndex].Cells[2].Value)
                {
                    isAllowedToAdd = false;
                }
            }
            if (isAllowedToAdd)
            {
                dataGridViewNewCheque.Rows.Add(dataGridViewProducts.Rows[dataGridViewProducts.CurrentCell.RowIndex].Cells[2].Value, 1);
            }
            RecalculateSum();
        }

        private void RecalculateSum()
        {
            connection.Open();
            double sum = 0;
            for (int i = 0; i < dataGridViewNewCheque.RowCount; i++)
            {
                double price = Convert.ToDouble(dataGridViewProducts.Rows[i].Cells[3].Value);
                sum = sum + (price * Convert.ToInt32(dataGridViewNewCheque.Rows[i].Cells[1].Value));
            }
            lblSum.Text = sum.ToString();
            connection.Close();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridViewNewCheque.Rows[dataGridViewNewCheque.CurrentCell.RowIndex];
            dataGridViewNewCheque.Rows.Remove(row);
            RecalculateSum();
        }

        private void RefreshProducts(string query)
        {
            string SqlText = query;
            SqlDataAdapter da = new SqlDataAdapter(SqlText, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "ProductsForCashier");
            dataGridViewProducts.DataSource = ds.Tables["ProductsForCashier"].DefaultView;
        }

        private void CashierMenu_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                RefreshProducts(defaultQuery);
            }
            catch (Exception exc)
            {
                AlertForm alert = new AlertForm();
                alert.showAlert(exc.Message, AlertForm.alertType.Error);
            }
        }

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

        private void dataGridViewNewCheque_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //int rowID = 0;
            //for (int i = 0; i < dataGridViewProducts.RowCount; i++)
            //{
            //    if (dataGridViewProducts.Rows[i].Cells[2].Value == dataGridViewNewCheque.Rows[dataGridViewNewCheque.CurrentCell.RowIndex].Cells[0].Value)
            //    {
            //        rowID = i;
            //    }
            //}
            //if (Convert.ToInt32(dataGridViewNewCheque.Rows[dataGridViewNewCheque.CurrentCell.RowIndex].Cells[1].Value) > Convert.ToInt32(dataGridViewProducts.Rows[rowID].Cells[4].Value))
            //{
            //    AlertForm alert = new AlertForm();
            //    alert.showAlert("Отсутствует необходимое кол-во товара на складе!", AlertForm.alertType.Error);
            //    dataGridViewNewCheque.Rows[dataGridViewNewCheque.CurrentCell.RowIndex].Cells[1].Value = 1;
            //}
            RecalculateSum();
        }


        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewNewCheque.RowCount == 0)
            {
                AlertForm alert1 = new AlertForm();
                alert1.showAlert("В чеке нет товаров!", AlertForm.alertType.Error);
                return;
            }


            bool isOK = true;
            foreach (DataGridViewRow row in dataGridViewNewCheque.Rows)
            {

                int rowID = 0;
                for (int i = 0; i < dataGridViewProducts.RowCount; i++)
                {
                    if (dataGridViewProducts.Rows[i].Cells[2].Value == row.Cells[0].Value)
                    {
                        rowID = i;
                    }
                }
                if (Convert.ToInt32(row.Cells[1].Value) > Convert.ToInt32(dataGridViewProducts.Rows[rowID].Cells[4].Value))
                {
                    AlertForm alert2 = new AlertForm();
                    alert2.showAlert("Отсутствует необходимое кол-во товара на складе!", AlertForm.alertType.Error);
                    row.Cells[1].Value = 1;
                    isOK = false;
                }
            }

            if (!isOK)
            {
                return;
            }
            connection.Open();
            double sum = Convert.ToDouble(lblSum.Text);
            //sum.Replace(",", ".");

            query = $"Insert into Cheque (Date_of_sale, Purchase_amount) values ('{DateTime.Now}', '{sum}')";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            reader.Close();

            query = $"Select @@IDENTITY";
            cmd = new SqlCommand(query, connection);
            int lastChequeID = Convert.ToInt32(cmd.ExecuteScalar());
            
            foreach (DataGridViewRow row in dataGridViewNewCheque.Rows)
            {
                query = $"Select Product_ID from Products where Name = N'{row.Cells[0].Value}'";
                cmd = new SqlCommand(query, connection);
                int productID = Convert.ToInt32(cmd.ExecuteScalar());

                query = $"Insert into Cheque_information (Cheque_ID, Product_ID, Quantity) values ({lastChequeID}, {productID}, {row.Cells[1].Value})";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                reader.Close();

                query = $"Select Quantity from Remains where Product_ID = {productID}";
                cmd = new SqlCommand(query, connection);
                int quantityRemains = Convert.ToInt32(cmd.ExecuteScalar());


                quantityRemains -= Convert.ToInt32(row.Cells[1].Value);

                query = $"Update Remains set Quantity = {quantityRemains} where Product_ID = {productID}";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                reader.Close();
            }
            connection.Close();

            AlertForm alert = new AlertForm();
            alert.showAlert("Чек проведён!", AlertForm.alertType.Success);
            RefreshProducts(defaultQuery);
            dataGridViewNewCheque.Rows.Clear();
            RecalculateSum();
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
