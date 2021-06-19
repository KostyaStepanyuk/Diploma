using FontAwesome.Sharp;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DiplomaTest.Secondary_forms
{
    public partial class ViewProductForm : Form
    {
        #region Variables

        private readonly string connectionString = @"Server=tcp:ubicakrovi.database.windows.net,1433;Initial Catalog=DiplomaTest;Persist Security Info=False;User ID=firetruck;Password=74Rjcnzy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection connection;
        private SqlDataReader reader = null;
        private SqlCommand cmd;
        private string query;
        private readonly Color  Black = Color.FromArgb(30, 39, 46),
                                DarkLightGrey = Color.FromArgb(85, 94, 101),
                                Red = Color.FromArgb(243, 31, 77),
                                White = Color.FromArgb(250, 242, 243);

        private readonly int productID;
        #endregion

        public ViewProductForm(int productID)
        {
            InitializeComponent();
            this.productID = productID;
        }

        private void CheckSize()
        {
            if (lblName.Size.Height > 30)
            {
                this.Size = new Size(902, 300);
            }
            else
            {
                this.Size = new Size(902, 265); 
            }
        }


        private void ProductView_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                query = $"Select * from ProductsView where Product_ID = '{productID}'";
                SqlCommand command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblArticle.Text = reader.GetString(1);
                        lblBarcode.Text = reader.GetString(2);
                        lblName.Text = reader.GetString(3);
                        lblProductName.Text = reader.GetString(3);
                        lblPrice.Text = reader.GetDecimal(6).ToString();
                        lblDepartment.Text = reader.GetString(7);
                        lblSupplier.Text = reader.GetString(8);
                    }
                }
                reader.Close();
                CheckSize();
            }
            catch (Exception exception)
            {
                AlertForm alert = new AlertForm();
                alert.showAlert(exception.Message, AlertForm.alertType.Error);
            }
        }
        private void lblName_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblName.Text);
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblPrice.Text);
        }

        private void lblSupplier_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblSupplier.Text);
        }

        private void lblDepartment_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblDepartment.Text);
        }

        private void lblBarcode_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblBarcode.Text);
        }

        private void lblArticle_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblArticle.Text);
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
