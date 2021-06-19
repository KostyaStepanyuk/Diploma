using DiplomaTest.Secondary_forms;
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
    public partial class StaleProducts : Form
    {
        #region Variables

        //DB variables
        private readonly string connectionString = @"Server=tcp:ubicakrovi.database.windows.net,1433;Initial Catalog=DiplomaTest;Persist Security Info=False;User ID=firetruck;Password=74Rjcnzy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection connection;
        private SqlDataReader reader = null;
        private string query;
        private readonly string defaultQuery = "select * from ChequeViewSecond";

        #endregion Variables

        public StaleProducts()
        {
            InitializeComponent();
        }

        private void RefreshStaleProducts(string query)
        {
            string SqlText = query + $" where Name not in (select name from ChequeViewSecond where Date_of_sale between '{rjDatePicker1.Value.Year + "-" + rjDatePicker1.Value.Month + "-" + rjDatePicker1.Value.Day}' and '{rjDatePicker2.Value.Year + "-" + rjDatePicker2.Value.Month + "-" + rjDatePicker2.Value.Day}') ";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "ChequeViewSecond");
            dataGridViewOrdersMain.DataSource = ds.Tables["ChequeViewSecond"].DefaultView;
        }

        private void StaleProducts_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                RefreshStaleProducts(defaultQuery);
            }
            catch (Exception exc)
            {
                AlertForm alert = new AlertForm();
                alert.showAlert(exc.Message, AlertForm.alertType.Error);
            }
        }

        private void rjDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            RefreshStaleProducts(defaultQuery);
        }

        private void rjDatePicker2_ValueChanged(object sender, EventArgs e)
        {
            RefreshStaleProducts(defaultQuery);
        }
    }
}
