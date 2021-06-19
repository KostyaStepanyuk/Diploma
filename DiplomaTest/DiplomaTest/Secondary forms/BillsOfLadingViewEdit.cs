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
    public partial class BillsOfLadingViewEdit : Form
    {
        #region Variables

        //DB variables
        private readonly string connectionString = @"Server=tcp:ubicakrovi.database.windows.net,1433;Initial Catalog=DiplomaTest;Persist Security Info=False;User ID=firetruck;Password=74Rjcnzy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection connection;
        private SqlDataReader reader = null;
        private SqlCommand cmd;
        private string query;
        private int billOfLadingID;
        private int oldQuantity = 0;

        private readonly Color Black = Color.FromArgb(30, 39, 46),
                               DarkLightGrey = Color.FromArgb(85, 94, 101),
                               Red = Color.FromArgb(243, 31, 77),
                               White = Color.FromArgb(250, 242, 243);

        public enum DataMode
        {
            Edit, 
            View
        }

        DataMode dataMode = new DataMode();

        #endregion Variables

        public BillsOfLadingViewEdit(int billOfLadingID, DataMode dataMode)
        {
            InitializeComponent();
            this.billOfLadingID = billOfLadingID;
            this.dataMode = dataMode;
        }

        private void BillsOfLading_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            string SqlText = $"Select * from BillsOfLadingsecondary where BillOfLading_ID = {billOfLadingID}";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "BillsOfLadingsecondary");
            dataGridViewBillOfLading.DataSource = ds.Tables["BillsOfLadingsecondary"].DefaultView;
            lblBillOfLadingNumber.Text += billOfLadingID.ToString();

            if (dataMode == DataMode.Edit)
            {
                dataGridViewBillOfLading.Columns["quantityDataGridViewTextBoxColumn"].ReadOnly = false;
            }
            else
            {
                dataGridViewBillOfLading.Columns["quantityDataGridViewTextBoxColumn"].ReadOnly = true;
            }
            
        }
        private void dataGridViewBillOfLading_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            connection.Open();
            query = $"Select Product_ID from Products where Name = N'{dataGridViewBillOfLading.Rows[dataGridViewBillOfLading.CurrentCell.RowIndex].Cells[0].Value}'";
            cmd = new SqlCommand(query, connection);
            int productID = Convert.ToInt32(cmd.ExecuteScalar());

            if (oldQuantity == Convert.ToInt32(dataGridViewBillOfLading.Rows[dataGridViewBillOfLading.CurrentCell.RowIndex].Cells[1].Value))
            {
                return;
            }

            int newQuantity = oldQuantity - Convert.ToInt32(dataGridViewBillOfLading.Rows[dataGridViewBillOfLading.CurrentCell.RowIndex].Cells[1].Value);
            query = $"Select Quantity from Remains where Product_ID = {productID}";
            cmd = new SqlCommand(query, connection);
            int quantityRemains = Convert.ToInt32(cmd.ExecuteScalar());

            int quantity = quantityRemains - newQuantity;
            query = $"update Remains set Quantity = {quantity} where Product_ID = {productID}";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            reader.Close();

            query = $"update BillOfLading_information set Quantity = {dataGridViewBillOfLading.Rows[dataGridViewBillOfLading.CurrentCell.RowIndex].Cells[1].Value} where Product_ID = {productID}";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            reader.Close();

            connection.Close();
        }

        private void dataGridViewBillOfLading_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldQuantity = Convert.ToInt32(dataGridViewBillOfLading.Rows[dataGridViewBillOfLading.CurrentCell.RowIndex].Cells[1].Value);
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
