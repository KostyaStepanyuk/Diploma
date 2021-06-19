using DiplomaTest.Secondary_forms;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

#pragma warning disable IDE1006 //Подавить проверку стилей именования

namespace DiplomaTest.Main_forms
{
    public partial class LoginForm : Form
    {
        #region Variables
        //Deafult variables
        private bool isUsernameChanged = false,
                     isPasswordChanged = false,
                     isPasswordVisible = false;
        private string username = "",
                       password = "",
                       query = "";
        private int userID = 0,
                    userTypeID;
        private readonly Color nonSelectedColor = Color.FromArgb(210, 218, 226),
                               selectedColor = Color.FromArgb(15, 188, 249);


        //DB variables
        private readonly string ConnectionString = @"Server=tcp:ubicakrovi.database.windows.net,1433;Initial Catalog=DiplomaTest;Persist Security Info=False;User ID=firetruck;Password=74Rjcnzy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection connection;
        private SqlDataReader reader = null;
        private SqlCommand cmd;
        #endregion Variables


        //Конструктор
        public LoginForm()
        {
            InitializeComponent();
            this.ActiveControl = FormTitle;
        }


        #region Methods


        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            textBoxUsername.ForeColor = selectedColor;
            iconUsername.IconColor = selectedColor;
            gunaSeparator1.LineColor = selectedColor;
            if (isUsernameChanged == false)
            {
                textBoxUsername.Text = "";
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            textBoxUsername.ForeColor = nonSelectedColor;
            iconUsername.IconColor = nonSelectedColor;
            gunaSeparator1.LineColor = nonSelectedColor;
            isUsernameChanged = true;
            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Username";
                isUsernameChanged = false;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            textBoxPassword.ForeColor = selectedColor;
            iconPassword.IconColor = selectedColor;
            gunaSeparator2.LineColor = selectedColor;
            iconButtonShowPass.IconColor = selectedColor;
            if (isPasswordChanged == false)
            {
                textBoxPassword.Text = "";
                textBoxPassword.PasswordChar = '•';
            }
        }

        private void FormTitle_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void LoginForm_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            textBoxPassword.ForeColor = nonSelectedColor;
            iconPassword.IconColor = nonSelectedColor;
            gunaSeparator2.LineColor = nonSelectedColor;
            iconButtonShowPass.IconColor = nonSelectedColor;
            isPasswordChanged = true;
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Password";
                isPasswordChanged = false;
                textBoxPassword.PasswordChar = '\0';
            }
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.IconColor = selectedColor;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.IconColor = nonSelectedColor;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonShowPass_Click(object sender, EventArgs e)
        {
            iconButtonShowPass.IconColor = nonSelectedColor;

            if (isPasswordVisible == false && isPasswordChanged == true)
            {
                textBoxPassword.PasswordChar = '\0';
                iconButtonShowPass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                isPasswordVisible = true;
                iconButtonShowPass.IconColor = selectedColor;
                this.ActiveControl = textBoxPassword;
            }
            else if (isPasswordVisible == true && isPasswordChanged == true)
            {
                textBoxPassword.PasswordChar = '•';
                iconButtonShowPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
                isPasswordVisible = false;
                iconButtonShowPass.IconColor = selectedColor;
                this.ActiveControl = textBoxPassword;
            }
        }

        private void iconButtonSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                username = textBoxUsername.Text;
                password = textBoxPassword.Text;
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                query = $"SELECT * FROM Users WHERE Username = N'{username}' COLLATE Latin1_General_CS_AS and Password = N'{password}' COLLATE Latin1_General_CS_AS";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    AlertForm newForm = new AlertForm();
                    newForm.showAlert("Неверное имя пользователя / пароль.", AlertForm.alertType.Error);
                    reader.Close();
                    return;
                }
                else
                {
                    reader.Close();
                    query = $"Select UserTypeID from Users where Username = N'{username}' COLLATE Latin1_General_CS_AS and Password = N'{password}' COLLATE Latin1_General_CS_AS";
                    cmd = new SqlCommand(query, connection);
                    userTypeID = Convert.ToInt32(cmd.ExecuteScalar());
                    reader.Close();
                    query = $"SELECT User_ID from Users WHERE Username = N'{username}' COLLATE Latin1_General_CS_AS and Password = N'{password}' COLLATE Latin1_General_CS_AS";
                    cmd = new SqlCommand(query, connection);
                    userID = Convert.ToInt32(cmd.ExecuteScalar());
                    reader.Close();
                    switch (userTypeID)
                    {
                        case 1:
                            {
                                AdminMenu adminForm = new AdminMenu();
                                adminForm.Show();
                                this.Hide();
                                break;
                            }
                        case 2:
                            {
                                DirectorMenu directorForm = new DirectorMenu();
                                directorForm.Show();
                                this.Hide();
                                break;
                            }
                        case 3:
                            {
                                DeputyDirectorMenu duputyDirectorForm = new DeputyDirectorMenu(userID);
                                duputyDirectorForm.Show();
                                this.Hide();
                                break;
                            }
                        case 4:
                            {
                                CommodityExpertMenu commodityExpertForm = new CommodityExpertMenu(userID);
                                commodityExpertForm.Show();
                                this.Hide();
                                break;
                            }
                        case 5:
                            {
                                //блин
                                break;
                            }
                        case 6:
                            {
                                CashierMenu cashierEForm = new CashierMenu();
                                cashierEForm.Show();
                                this.Hide();
                                break;
                            }
                    }
                }
            }
            catch (Exception exception)
            {
                AlertForm newForm = new AlertForm();
                newForm.showAlert(exception.Message, AlertForm.alertType.Error);
            }
        }


        #endregion
    }
}
