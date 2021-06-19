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
    public partial class AddEditViewSupplierForm : Form
    {
        #region Variables

        //DB variables
        private readonly string connectionString = @"Server=tcp:ubicakrovi.database.windows.net,1433;Initial Catalog=DiplomaTest;Persist Security Info=False;User ID=firetruck;Password=74Rjcnzy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection connection;
        private SqlDataReader reader = null;
        private SqlCommand cmd;
        private string query;
        private string userType;
        private int userTypeID;
        private string oldUNP, oldPassword;
        private bool isSuccess = false;
        private string supplierUNP;

        private readonly Color Black = Color.FromArgb(30, 39, 46),
                               DarkLightGrey = Color.FromArgb(85, 94, 101),
                               Gray = Color.FromArgb(128, 142, 155),
                               LightGray = Color.FromArgb(210, 218, 226),
                               Green = Color.FromArgb(5, 196, 107),
                               Cyan = Color.FromArgb(52, 231, 228),
                               Red = Color.FromArgb(243, 31, 77),
                               White = Color.FromArgb(250, 242, 243);

        public enum DataMode
        {
            Add,
            Edit,
            Delete,
            View
        }
        private DataMode dataMode = new DataMode();

        #endregion Variables

        public AddEditViewSupplierForm(DataMode dataMode, string supplierUNP)
        {
            InitializeComponent();
            this.dataMode = dataMode;
            this.supplierUNP = supplierUNP;
            connection = new SqlConnection(connectionString);
        }

        private void ChangeFieldsStatus(DataMode dataMode)
        {
            if (dataMode == DataMode.View)
            {
                textBoxUNP.ReadOnly = true;
                textBoxName.ReadOnly = true;
                textBoxWebsite.ReadOnly = true;
                textBoxPhoneNumber.ReadOnly = true;
                textBoxAddress.ReadOnly = true;
                this.Size = new Size(608, 343);
            }
            else
            {
                textBoxUNP.ReadOnly = false;
                textBoxName.ReadOnly = false;
                textBoxWebsite.ReadOnly = false;
                textBoxPhoneNumber.ReadOnly = false;
                textBoxAddress.ReadOnly = false;
                this.Size = new Size(608, 343);
            }
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            connection.Open();

            switch (dataMode)
            {
                case DataMode.Add:
                    {
                        lblModeUserTitle.Text = "Добавление нового поставщика";
                        ChangeFieldsStatus(dataMode);
                        break;
                    }
                case DataMode.Edit:
                    {
                        query = $"Select * from Suppliers WHERE UNP = N'{supplierUNP}'";
                        cmd = new SqlCommand(query, connection);
                        reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                textBoxUNP.Text = reader.GetString(0);
                                textBoxName.Text = reader.GetString(1);
                                textBoxWebsite.Text = reader.GetString(2);
                                textBoxPhoneNumber.Text = reader.GetString(3);
                                textBoxAddress.Text = reader.GetString(4);
                                textBoxEmail.Text = reader.GetString(5);
                            }
                        }
                        lblModeUserTitle.Text = "Редактирование поставщика";
                        RememberOldData();
                        ChangeFieldsStatus(dataMode);
                        break;
                    }
                case DataMode.View:
                    {
                        query = $"Select * from Suppliers WHERE UNP = {supplierUNP}";
                        cmd = new SqlCommand(query, connection);
                        reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                textBoxUNP.Text = reader.GetString(0);
                                textBoxName.Text = reader.GetString(1);
                                textBoxWebsite.Text = reader.GetString(2);
                                textBoxPhoneNumber.Text = reader.GetString(3);
                                textBoxAddress.Text = reader.GetString(4);
                                textBoxEmail.Text = reader.GetString(5);
                            }
                        }
                        lblModeUserTitle.Text = "Просмотр поставщика";
                        ChangeFieldsStatus(dataMode);
                        break;
                    }
            }



            connection.Close();
        }

        private bool ContainsLetters(string line)
        {
            bool result = false;
            for (char number = 'a'; number < 'Z'; number++)
            {
                if (line.Contains(number))
                {
                    result = true;
                }
            }
            return result;
        }

        private int CheckIfExist()
        {
            if (oldUNP == textBoxUNP.Text)
            {
                return 0;
            }
            connection.Open();
            query = $"Select count(*) from Suppliers where UNP = N'{textBoxUNP.Text}'";
            cmd = new SqlCommand(query, connection);
            int buffer = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            return buffer;
        }

        private void RememberOldData()
        {
            oldUNP = textBoxUNP.Text;
        }

        private string IsUserCorrect()
        {
            textBoxUNP.Text = textBoxUNP.Text.Trim();
            textBoxName.Text = textBoxName.Text.Trim();
            textBoxWebsite.Text = textBoxWebsite.Text.Trim();
            textBoxPhoneNumber.Text = textBoxPhoneNumber.Text.Trim();
            textBoxAddress.Text = textBoxAddress.Text.Trim();
            textBoxEmail.Text = textBoxEmail.Text.Trim();
            string exceptionMessege;

            if (string.IsNullOrWhiteSpace(textBoxUNP.Text) || string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxWebsite.Text) || string.IsNullOrWhiteSpace(textBoxPhoneNumber.Text) || string.IsNullOrWhiteSpace(textBoxAddress.Text) || string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                exceptionMessege = "Все поля должны быть заполнены.";
            }
            else if (ContainsLetters(textBoxUNP.Text))
            {
                exceptionMessege = "УНП производителя должно содержать только цифры.";
            }
            
            else if (CheckIfExist() > 0)
            {
                exceptionMessege = "Поставщик с таким УНП уже существует.";
            }
            else
            {
                exceptionMessege = "";
            }
            return exceptionMessege;
        }

        private void AddUser()
        {
            try
            {
                if (string.IsNullOrEmpty(IsUserCorrect()))
                {
                    connection.Open();
                    query = $"insert into Suppliers (UNP, Name, Website, PhoneNumber, Address, Email) values(N'{textBoxUNP.Text}', N'{textBoxName.Text}', N'{textBoxWebsite.Text}', N'{textBoxPhoneNumber.Text}', N'{textBoxAddress.Text}', N'{textBoxEmail.Text}')";
                    cmd = new SqlCommand(query, connection);
                    reader = cmd.ExecuteReader();
                    reader.Close();
                    connection.Close();
                    isSuccess = true;
                }
                else
                {
                    AlertForm alert = new AlertForm();
                    alert.showAlert(IsUserCorrect(), AlertForm.alertType.Error);
                }
            }
            catch (Exception exception)
            {
                AlertForm alert = new AlertForm();
                alert.showAlert(exception.Message, AlertForm.alertType.Error);
            }
        }

        private void EditUser()
        {
            if (string.IsNullOrEmpty(IsUserCorrect()))
            {
                connection.Open();
                query = $"update Suppliers set UNP = N'{textBoxUNP.Text}', Name = N'{textBoxName.Text}', Website = N'{textBoxWebsite.Text}', PhoneNumber = N'{textBoxPhoneNumber.Text}', Address = N'{textBoxAddress.Text}', Email = N'{textBoxEmail.Text}' where UNP = N'{supplierUNP}'";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                reader.Close();
                connection.Close();
                isSuccess = true;
            }
            else
            {
                AlertForm alert = new AlertForm();
                alert.showAlert(IsUserCorrect(), AlertForm.alertType.Error);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            switch (dataMode)
            {
                case DataMode.Add:
                    {
                        AddUser();
                        break;
                    }
                case DataMode.Edit:
                    {
                        EditUser();
                        break;
                    }
            }
            if (isSuccess)
            {
                this.Close();
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
