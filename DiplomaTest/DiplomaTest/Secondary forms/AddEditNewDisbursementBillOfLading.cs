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
    public partial class AddEditNewDisbursementBillOfLading : Form
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
        int DBOL_ID = 0;
        int oldQuantity = 0;

        private readonly Color Black = Color.FromArgb(30, 39, 46),
                                DarkLightGrey = Color.FromArgb(85, 94, 101),
                                Gray = Color.FromArgb(128, 142, 155),
                                LightGray = Color.FromArgb(210, 218, 226),
                                Green = Color.FromArgb(5, 196, 107),
                                Cyan = Color.FromArgb(52, 231, 228),
                                Red = Color.FromArgb(243, 31, 77),
                                White = Color.FromArgb(250, 242, 243);


        #endregion Variables
        public AddEditNewDisbursementBillOfLading(int currentCustomerID)
        {
            InitializeComponent();
            this.currentCustomerID = currentCustomerID;
        }

        public AddEditNewDisbursementBillOfLading(int currentCustomerID, int DBOL_ID)
        {
            InitializeComponent();
            this.currentCustomerID = currentCustomerID;
            this.DBOL_ID = DBOL_ID;
        }

        private void LoadSuppliers()
        {
            connection.Open();
            query = $"Select Name from Suppliers";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBoxSuppliers.Items.Add(reader.GetString(0));
                }
            }
            reader.Close();
            connection.Close();
        }

        

        private void AddEditNewDisbursementBillOfLading_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                LoadSuppliers();
                comboBoxSuppliers.SelectedIndex = 0;


                connection.Open();

                

                if (DBOL_ID != 0)
                {

                    query = $"Select Supplier_UNP from DisbursementBOL where DisbursementBOL_ID = {DBOL_ID}";
                    cmd = new SqlCommand(query, connection);
                    int supplierUNP = Convert.ToInt32(cmd.ExecuteScalar());

                    query = $"Select Name from Suppliers where UNP = N'{supplierUNP}'";
                    cmd = new SqlCommand(query, connection);
                    string supplierName = cmd.ExecuteScalar().ToString();



                    for (int i = 0; i < comboBoxSuppliers.Items.Count; i++)
                    {
                        if (comboBoxSuppliers.Items[i].ToString() == supplierName)
                        {
                            comboBoxSuppliers.SelectedIndex = i;
                            
                            break;
                        }
                    }
                    
                }

                
                
                connection.Close();
            }
            catch (Exception exception)
            {
                AlertForm alert = new AlertForm();
                alert.showAlert(exception.Message, AlertForm.alertType.Error);
                connection.Close();
            }
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

        private void RefreshDBOL(string supplierName)
        {
            string SqlText = $"Select * from DisbursementBillsOfLadingSecondary where SupplierName = N'{supplierName}'";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "DisbursementBillsOfLadingSecondary");
            dataGridViewNewDBOL.DataSource = ds.Tables["DisbursementBillsOfLadingSecondary"].DefaultView;
        }

        private void comboBoxSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();

            query = $"Select UNP from Suppliers where Name = N'{comboBoxSuppliers.Text}'";
            cmd = new SqlCommand(query, connection);
            string supplierUNP = cmd.ExecuteScalar().ToString();

            query = $"select count(*) from DisbursementBOL where Supplier_UNP = '{supplierUNP}' and Status = N'В ожидании'";
            cmd = new SqlCommand(query, connection);
            int buff = Convert.ToInt32(cmd.ExecuteScalar());

            if (buff > 0)
            {
                RefreshDBOL(comboBoxSuppliers.Text);
                lblModeUserTitle.Text = dataGridViewNewDBOL.Rows[0].Cells[0].Value.ToString();
            }
            else
            {
                query = $"insert into DisbursementBOL (Date, Supplier_UNP, User_ID, Status) " +
                    $"values ('{DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year}', {supplierUNP}, {currentCustomerID}, N'В ожидании')";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                reader.Close();

                query = $"select @@IDENTITY";
                cmd = new SqlCommand(query, connection);
                string ttnnumber = cmd.ExecuteScalar().ToString();

                lblModeUserTitle.Text = "ТТН №" + ttnnumber;

                RefreshDBOL(comboBoxSuppliers.Text);
            }
            
            connection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RemainsList remains = new RemainsList(comboBoxSuppliers.Text);
            remains.ShowDialog();
            if (remains.DialogResult != DialogResult.Cancel)
            {
                RefreshDBOL(comboBoxSuppliers.Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewNewDBOL.RowCount == 0)
            {
                return;
            }

            connection.Open();

            query = $"Select Product_ID from Products where Name = N'{dataGridViewNewDBOL.Rows[dataGridViewNewDBOL.CurrentCell.RowIndex].Cells[1].Value}'";
            cmd = new SqlCommand(query, connection);
            int productID = Convert.ToInt32(cmd.ExecuteScalar());

            query = $"Delete from DisbursementBOL_information where DBOL_ID = {dataGridViewNewDBOL.Rows[dataGridViewNewDBOL.CurrentCell.RowIndex].Cells[0].Value} and Product_ID = {productID}";
            cmd = new SqlCommand(query,connection);
            reader = cmd.ExecuteReader();
            reader.Close();

            query = $"Select Quantity from Remains where Product_ID = {productID}";
            cmd = new SqlCommand(query, connection);
            int quantityRemains = Convert.ToInt32(cmd.ExecuteScalar());

            quantityRemains += Convert.ToInt32(dataGridViewNewDBOL.Rows[dataGridViewNewDBOL.CurrentCell.RowIndex].Cells[2].Value);

            query = $"update remains set Quantity = {quantityRemains} where Product_ID = {productID}";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            reader.Close();

            RefreshDBOL(comboBoxSuppliers.Text);

            connection.Close();
        }

        private void dataGridViewNewDBOL_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                connection.Open();
                query = $"Select product_id from products where name = N'{dataGridViewNewDBOL.Rows[dataGridViewNewDBOL.CurrentCell.RowIndex].Cells[1].Value}'";
                cmd = new SqlCommand(query, connection);
                int productID = Convert.ToInt32(cmd.ExecuteScalar());

                query = $"Select Quantity from Remains where Product_ID = {productID}";
                cmd = new SqlCommand(query, connection);
                int quantityRemains = Convert.ToInt32(cmd.ExecuteScalar());

                if (Convert.ToInt32(dataGridViewNewDBOL.Rows[dataGridViewNewDBOL.CurrentCell.RowIndex].Cells[2].Value) != oldQuantity)
                {
                    int endQuantity = quantityRemains + (oldQuantity - Convert.ToInt32(dataGridViewNewDBOL.Rows[dataGridViewNewDBOL.CurrentCell.RowIndex].Cells[2].Value));

                    if (endQuantity < 0)
                    {
                        AlertForm alert = new AlertForm();
                        alert.showAlert("На складе отсутсвует необходимое кол-во продукта!", AlertForm.alertType.Error);
                        dataGridViewNewDBOL.Rows[dataGridViewNewDBOL.CurrentCell.RowIndex].Cells[2].Value = 1;
                        return;
                    }

                    query = $"update DisbursementBOL_information set Quantity = {Convert.ToInt32(dataGridViewNewDBOL.Rows[dataGridViewNewDBOL.CurrentCell.RowIndex].Cells[2].Value)} where Product_ID = {productID} and DBOL_ID = {dataGridViewNewDBOL.Rows[dataGridViewNewDBOL.CurrentCell.RowIndex].Cells[0].Value}";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            AlertForm alert = new AlertForm();
            alert.showAlert("Успешно сохранено!", AlertForm.alertType.Success);
            this.Close();
        }

        private void dataGridViewNewDBOL_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldQuantity = Convert.ToInt32(dataGridViewNewDBOL.Rows[dataGridViewNewDBOL.CurrentCell.RowIndex].Cells[2].Value);
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
