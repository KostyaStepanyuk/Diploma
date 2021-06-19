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

namespace DiplomaTest.Child_forms
{
    public partial class StoreInfo : Form
    {
        #region Variables

        //DB variables
        private readonly string connectionString = @"Server=tcp:ubicakrovi.database.windows.net,1433;Initial Catalog=DiplomaTest;Persist Security Info=False;User ID=firetruck;Password=74Rjcnzy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection connection;
        private SqlDataReader reader = null;
        private SqlCommand cmd;
        private string query;

        #endregion Variables

        public StoreInfo()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            query = $"Select count(*) from Store_information";
            cmd = new SqlCommand(query, connection);
            int check = Convert.ToInt32(cmd.ExecuteScalar());
            if (check != 0)
            {
                query = $"Update Store_information set " +
                    $"Name = N'{textBoxName.Text}', " +
                    $"WarehouseAddress = N'{textBoxAddress.Text}', " +
                    $"EmailLogin = N'{textBoxEmailLogin.Text}', " +
                    $"EmailPassword = N'{textBoxEmailPassword.Text}'," +
                    $"ValueAddedRatio = '{textBoxValueAddedRatio.Text}'";
            }
            else
            {
                query = $"Insert into Store_information " +
                    $"(Name, WarehouseAddress, EmailLogin, EmailPassword, ValueAddedRatio) values " +
                    $"(N'{textBoxName.Text}', " +
                    $"N'{textBoxAddress.Text}', " +
                    $"N'{textBoxEmailLogin.Text}', " +
                    $"N'{textBoxEmailPassword.Text}', " + 
                    $"N'{textBoxValueAddedRatio.Text}')";
            }
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            reader.Close();
            connection.Close();
        }

        private void StoreInfo_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            query = $"Select * from Store_information";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    textBoxName.Text = reader.GetString(0);
                    textBoxAddress.Text = reader.GetString(1);
                    textBoxEmailLogin.Text = reader.GetString(2);
                    textBoxEmailPassword.Text = reader.GetString(3);
                    textBoxValueAddedRatio.Text = reader.GetInt32(4).ToString();
                }
            }
            reader.Close();
            connection.Close();
        }
    }
}
