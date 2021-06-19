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
    public partial class AddEditViewUserForm : Form
    {
        #region Variables

        //DB variables
        private readonly string connectionString = @"Server=tcp:ubicakrovi.database.windows.net,1433;Initial Catalog=DiplomaTest;Persist Security Info=False;User ID=firetruck;Password=74Rjcnzy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection connection;
        private SqlDataReader reader = null;
        private SqlCommand cmd;
        private string query;
        private string userType;
        private int userTypeID, userID;
        private string oldUsername, oldPassword;
        private bool isSuccess = false;

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

        public AddEditViewUserForm(DataMode dataMode, string userType, int userTypeID, int userID)
        {
            InitializeComponent();
            this.dataMode = dataMode;
            this.userType = userType;
            this.userTypeID = userTypeID;
            this.userID = userID;
            connection = new SqlConnection(connectionString);
        }

        private void ChangeFieldsStatus(DataMode dataMode)
        {
            if (dataMode == DataMode.View)
            {
                textBoxName.ReadOnly = true;
                textBoxSurname.ReadOnly = true;
                textBoxPatronymic.ReadOnly = true;
                textBoxUsername.ReadOnly = true;
                textBoxPassword.ReadOnly = true;
                this.Size = new Size(575, 245);
            }
            else
            {
                textBoxName.ReadOnly = false;
                textBoxSurname.ReadOnly = false;
                textBoxPatronymic.ReadOnly = false;
                textBoxUsername.ReadOnly = false;
                textBoxPassword.ReadOnly = false;
                this.Size = new Size(575, 310);
            }
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            connection.Open();

            switch (dataMode)
            {
                case DataMode.Add:
                    {
                        lblModeUserTitle.Text = "Добавление нового " + userType;
                        ChangeFieldsStatus(dataMode);
                        break;
                    }
                case DataMode.Edit:
                    {
                        query = $"Select * from Users WHERE User_ID = {userID}";
                        cmd = new SqlCommand(query, connection);
                        reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                textBoxUsername.Text = reader.GetString(1);
                                textBoxPassword.Text = reader.GetString(2);
                                textBoxName.Text = reader.GetString(3);
                                textBoxSurname.Text = reader.GetString(4);
                                textBoxPatronymic.Text = reader.GetString(5);
                            }
                        }
                        lblModeUserTitle.Text = "Редактирование " + userType;
                        RememberOldData();
                        ChangeFieldsStatus(dataMode);
                        break;
                    }
                case DataMode.View:
                    {
                        query = $"Select * from Users WHERE User_ID = {userID}";
                        cmd = new SqlCommand(query, connection);
                        reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                textBoxUsername.Text = reader.GetString(1);
                                textBoxPassword.Text = reader.GetString(2);
                                textBoxName.Text = reader.GetString(3);
                                textBoxSurname.Text = reader.GetString(4);
                                textBoxPatronymic.Text = reader.GetString(5);
                            }
                        }
                        lblModeUserTitle.Text = "Просмотр " + userType;
                        ChangeFieldsStatus(dataMode);
                        break;
                    }
            }



            connection.Close();
        }

        private bool ContainsNumbers(string line)
        {
            bool result = false;
            for (char number = '0'; number < '9'; number++)
            {
                if (line.Contains(number))
                {
                    result = true;
                }
            }
            return result;
        }

        private void AutoCorrectName()
        {
            if (char.IsLower(textBoxName.Text.First()))
            {
                StringBuilder a = new StringBuilder(textBoxName.Text);
                a[0] = char.ToUpper(textBoxName.Text.First());
                textBoxName.Text = a.ToString();
            }
            if (char.IsLower(textBoxSurname.Text.First()))
            {
                StringBuilder a = new StringBuilder(textBoxSurname.Text);
                a[0] = char.ToUpper(textBoxSurname.Text.First());
                textBoxSurname.Text = a.ToString();
            }
            if (char.IsLower(textBoxPatronymic.Text.First()))
            {
                StringBuilder a = new StringBuilder(textBoxPatronymic.Text);
                a[0] = char.ToUpper(textBoxPatronymic.Text.First());
                textBoxPatronymic.Text = a.ToString();
            }
        }

        private int CheckIfExist()
        {
            if (oldUsername == textBoxUsername.Text || oldPassword == textBoxPassword.Text)
            {
                return 0;
            }
            connection.Open();
            query = $"Select count(*) from Users where Username = N'{textBoxUsername.Text}' and Password = N'{textBoxPassword.Text}'";
            cmd = new SqlCommand(query, connection);
            int buffer = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            return buffer;
        }

        private void RememberOldData()
        {
            oldUsername = textBoxUsername.Text;
            oldPassword = textBoxPassword.Text;
        }

        private string IsUserCorrect()
        {
            textBoxName.Text = textBoxName.Text.Trim();
            textBoxSurname.Text = textBoxSurname.Text.Trim();
            textBoxPatronymic.Text = textBoxPatronymic.Text.Trim();
            textBoxUsername.Text = textBoxUsername.Text.Trim();
            textBoxPassword.Text = textBoxPassword.Text.Trim();
            string exceptionMessege;

            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxSurname.Text) || string.IsNullOrWhiteSpace(textBoxPatronymic.Text) || string.IsNullOrWhiteSpace(textBoxUsername.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                exceptionMessege = "Все поля должны быть заполнены.";
            }
            else if (ContainsNumbers(textBoxName.Text))
            {
                exceptionMessege = "Имя пользователя не должно содержать цифр.";
            }
            else if (ContainsNumbers(textBoxSurname.Text))
            {
                exceptionMessege = "Фамилия пользователя не должна содержать цифр.";
            }
            else if (ContainsNumbers(textBoxPatronymic.Text))
            {
                exceptionMessege = "Отчество пользователя не должно содержать цифр.";
            }
            else if (CheckIfExist() > 0)
            {
                exceptionMessege = "Менеджер с таким логином и паролем уже существует.";
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
                    AutoCorrectName();
                    connection.Open();
                    query = $"insert into Users (Username, Password, Name, Surname, Patronymic, UserTypeID) values(N'{textBoxUsername.Text}', N'{textBoxPassword.Text}', N'{textBoxName.Text}', N'{textBoxSurname.Text}', N'{textBoxPatronymic.Text}', {userTypeID})";
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
                AutoCorrectName();
                connection.Open();
                query = $"update Users set Username = N'{textBoxUsername.Text}', Password = N'{textBoxPassword.Text}', Name = N'{textBoxName.Text}', Surname = N'{textBoxSurname.Text}', Patronymic = N'{textBoxPatronymic.Text}' where User_ID = N'{userID}'";
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
