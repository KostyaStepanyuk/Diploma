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
    public partial class RemainsList : Form
    {
        #region Variables

        //DB variables
        private readonly string connectionString = @"Server=tcp:ubicakrovi.database.windows.net,1433;Initial Catalog=DiplomaTest;Persist Security Info=False;User ID=firetruck;Password=74Rjcnzy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection connection;
        private SqlDataReader reader = null;
        private SqlCommand cmd;
        private string query;
        private readonly string defaultQuery = "Select * from Remains";
        string supplierName;

        private readonly Color Black = Color.FromArgb(30, 39, 46),
                                DarkLightGrey = Color.FromArgb(85, 94, 101),
                                Gray = Color.FromArgb(128, 142, 155),
                                LightGray = Color.FromArgb(210, 218, 226),
                                Green = Color.FromArgb(5, 196, 107),
                                Cyan = Color.FromArgb(52, 231, 228),
                                Red = Color.FromArgb(243, 31, 77),
                                White = Color.FromArgb(250, 242, 243);


        #endregion Variables
        public RemainsList(string supplierName)
        {
            InitializeComponent();
            this.supplierName = supplierName;
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

        private void RefreshRemains(string supplierName)
        {
            string SqlText = $"Select * from RemainsFullView where SupplierName = N'{supplierName}' and Quantity > 0";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "RemainsFullView");
            dataGridViewProducts.DataSource = ds.Tables["RemainsFullView"].DefaultView;
        }

        private void RemainsList_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                RefreshRemains(supplierName);
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

            query = $"Select UNP from Suppliers where Name = N'{supplierName}'";
            cmd = new SqlCommand(query, connection);
            string supplierUNP = cmd.ExecuteScalar().ToString();

            query = $"Select DisbursementBOL_ID from DisbursementBOL where Supplier_UNP = N'{supplierUNP}' and Status = N'В ожидании'";
            cmd = new SqlCommand(query, connection);
            int DBOL_ID = Convert.ToInt32(cmd.ExecuteScalar());

            query = $"Select Product_ID from Products where Name = N'{dataGridViewProducts.Rows[dataGridViewProducts.CurrentCell.RowIndex].Cells[2].Value}'";
            cmd = new SqlCommand(query, connection);
            int productID = Convert.ToInt32(cmd.ExecuteScalar());

            query = $"select count(*) from DisbursementBOL_information where DBOL_ID = {DBOL_ID} and product_id = {productID}";
            cmd = new SqlCommand(query, connection);
            int buff = Convert.ToInt32(cmd.ExecuteScalar());

            if (buff == 0)
            {
                query = $"insert into DisbursementBOL_information (DBOL_ID, Product_ID, Quantity) values ({DBOL_ID}, {productID}, 1)";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                reader.Close();

                query = $"Select Quantity from remains where product_id = {productID}";
                cmd = new SqlCommand(query, connection);
                int quantityRemains = Convert.ToInt32(cmd.ExecuteScalar());

                query = $"update Remains set Quantity = {quantityRemains - 1} where product_id = {productID}";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                reader.Close();
            }
            connection.Close();

            this.DialogResult = DialogResult.OK;
            this.Close();
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
