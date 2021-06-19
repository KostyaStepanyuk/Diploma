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
    public partial class Remains : Form
    {
        #region Variables

        //DB variables
        private readonly string connectionString = @"Server=tcp:ubicakrovi.database.windows.net,1433;Initial Catalog=DiplomaTest;Persist Security Info=False;User ID=firetruck;Password=74Rjcnzy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection connection;
        private SqlDataReader reader = null;
        private SqlCommand cmd;
        private string query;
        private readonly string defaultQuery = "Select * from RemainsView";
        int currentCustomerID;
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
        public Remains()
        {
            InitializeComponent();
        }

        private void RefreshRemainsData(string query)
        {
            string SqlText = query;
            SqlDataAdapter da = new SqlDataAdapter(SqlText, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "RemainsView");
            dataGridViewRemains.DataSource = ds.Tables["RemainsView"].DefaultView;
        }

        private void Remains_Load(object sender, EventArgs e)
        {
            RefreshRemainsData(defaultQuery);
        }

        private void RefreshRemains()
        {
            int count = 0;
            string query = "Select * from RemainsView ";
            if (!string.IsNullOrEmpty(textBoxName.Text))
            {
                query += $" where Name like N'%{textBoxName.Text}%' ";
                count++;
            }
            if (!string.IsNullOrEmpty(textBoxQuantityFrom.Text))
            {
                if (count == 0)
                {
                    query += $" where Quantity >= {textBoxQuantityFrom.Text} ";
                    count++;
                }
                else
                {
                    query += $"and Quantity >= {textBoxQuantityFrom.Text} ";
                    count++;
                }
            }
            if (!string.IsNullOrEmpty(textBoxQuantityTo.Text))
            {
                if (count == 0)
                {
                    query += $" where Quantity <= {textBoxQuantityTo.Text} ";
                    count++;
                }
                else
                {
                    query += $"and Quantity <= {textBoxQuantityTo.Text} ";
                    count++;
                }
            }
            if (!string.IsNullOrEmpty(textBoxPriceFrom.Text))
            {
                if (count == 0)
                {
                    query += $" where Price >= {textBoxPriceFrom.Text} ";
                    count++;
                }
                else
                {
                    query += $"and Price >= {textBoxPriceFrom.Text} ";
                    count++;
                }
            }
            if (!string.IsNullOrEmpty(textBoxPriceTo.Text))
            {
                if (count == 0)
                {
                    query += $" where Price <= {textBoxPriceTo.Text} ";
                    count++;
                }
                else
                {
                    query += $"and Price <= {textBoxPriceTo.Text} ";
                    count++;
                }
            }
            RefreshRemainsData(query);
        }



        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            RefreshRemains();
        }

        private void textBoxPriceFrom_TextChanged(object sender, EventArgs e)
        {
            RefreshRemains();
        }

        private void textBoxPriceTo_TextChanged(object sender, EventArgs e)
        {
            RefreshRemains();
        }

        private void textBoxPriceFrom_TextChanged_1(object sender, EventArgs e)
        {
            RefreshRemains();
        }

        private void textBoxpriceTo_TextChanged_1(object sender, EventArgs e)
        {
            RefreshRemains();
        }
    }
}
