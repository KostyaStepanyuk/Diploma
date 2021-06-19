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
    public partial class ImplementationStat : Form
    {
        #region Variables

        //DB variables
        private readonly string connectionString = @"Server=tcp:ubicakrovi.database.windows.net,1433;Initial Catalog=DiplomaTest;Persist Security Info=False;User ID=firetruck;Password=74Rjcnzy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection connection;
        private SqlDataReader reader = null;
        private string query;
        private readonly string defaultQuery = "select * from Cheque";

        #endregion Variables
        public ImplementationStat()
        {
            InitializeComponent();
        }

        public void RefreshImplementationStat(string query)
        {
            string SqlText = query + $" where Date_of_sale between '{rjDatePicker1.Value}' and '{rjDatePicker2.Value}'";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Cheque");
            dataGridViewOrdersMain.DataSource = ds.Tables["Cheque"].DefaultView;
        }

        private void ImplementationStat_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                RefreshImplementationStat(defaultQuery);
            }
            catch (Exception exc)
            {
                AlertForm alert = new AlertForm();
                alert.showAlert(exc.Message, AlertForm.alertType.Error);
            }
        }

        private void rjDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            RefreshImplementationStat(defaultQuery);
        }

        private void rjDatePicker2_ValueChanged(object sender, EventArgs e)
        {
            RefreshImplementationStat(defaultQuery);
        }

        private void dataGridViewOrdersMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewOrdersMain_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ChequeView form = new ChequeView(Convert.ToInt32(dataGridViewOrdersMain.Rows[dataGridViewOrdersMain.CurrentCell.RowIndex].Cells[0].Value));
            form.Show();
        }
    }
}
