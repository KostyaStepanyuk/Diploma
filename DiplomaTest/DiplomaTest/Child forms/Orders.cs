using DiplomaTest.Secondary_forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace DiplomaTest.Child_forms
{
    public partial class Orders : Form
    {
        #region Variables

        //DB variables
        private readonly string connectionString = @"Server=tcp:ubicakrovi.database.windows.net,1433;Initial Catalog=DiplomaTest;Persist Security Info=False;User ID=firetruck;Password=74Rjcnzy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection connection;
        private SqlDataReader reader = null;
        private SqlCommand cmd;
        private string query;
        private readonly string defaultMainQuery = "Select * from OrdersViewMain order by OrderDate";
        private readonly int commodityExpertID;
        private string  currentSupplierUNP;

        public enum DataMode
        {
            Add,
            Edit,
            View
        }
        public DataMode dataMode = new DataMode();

        #endregion Variables
        public Orders(int commodityExpertID, DataMode dataMode)
        {
            InitializeComponent();
            this.commodityExpertID = commodityExpertID;
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            this.dataMode = dataMode;
        }

        #region Methods


        //Update dataGridView info
        public void RefreshMainOrders(string query)
        {
            string SqlText = query;
            SqlDataAdapter da = new SqlDataAdapter(SqlText, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "OrdersViewMain");
            dataGridViewOrdersMain.DataSource = ds.Tables["OrdersViewMain"].DefaultView;
        }

        //Form load
        private void Orders_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                RefreshMainOrders(defaultMainQuery);
                connection.Close();
                if (dataMode == DataMode.View)
                {
                    btnAddEditOrder.Visible = false;
                    btnSendOrder.Visible = false;
                    btnSaveOrder.Visible = false;
                }
                connection.Open();
                query = $"select UNP from Suppliers where Name = N'{dataGridViewOrdersMain.Rows[0].Cells[5].Value}'";
                cmd = new SqlCommand(query, connection);
                currentSupplierUNP = cmd.ExecuteScalar().ToString();
                connection.Close();
            }
            catch (Exception exception)
            {
                AlertForm alert = new AlertForm();
                alert.showAlert(exception.Message, AlertForm.alertType.Error);
            }
        }

        private void dataGridViewOrdersMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedOrderID = Convert.ToInt32(dataGridViewOrdersMain.Rows[dataGridViewOrdersMain.CurrentCell.RowIndex].Cells[0].Value);
            Secondary_forms.Orders ordersForm = new Secondary_forms.Orders(selectedOrderID);
            ordersForm.Show();
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearch.Text))
            {
                SwapSearchVisible();
            }
            else
            {
                SearchOrder();
            }
        }

        private void SwapSearchVisible()
        {
            if (textBoxSearch.Visible == true)
            {
                pnlSearchUnderline.Visible = false;
                textBoxSearch.Visible = false;
                RefreshMainOrders(defaultMainQuery);
            }
            else
            {
                pnlSearchUnderline.Visible = true;
                textBoxSearch.Visible = true;
                textBoxSearch.Focus();
            }
        }

        private void SearchOrder()
        {
            query = $"Select * from OrdersViewMain where concat(Order_ID, CustomerFullName, OrderDate, DeliveryDate, Status, Name) like N'%{textBoxSearch.Text}%'";
            RefreshMainOrders(query);
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                SearchOrder();
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (dataMode == DataMode.Edit)
            {
                NewOrder newOrder = new NewOrder(commodityExpertID, NewOrder.DataMode.Edit, dataGridViewOrdersMain.Rows[dataGridViewOrdersMain.CurrentCell.RowIndex].Cells[5].Value.ToString());
                newOrder.Show();
            }
            if (dataMode == DataMode.Add)
            {
                NewOrder newOrder = new NewOrder(commodityExpertID, NewOrder.DataMode.Add);
                newOrder.Show();
            }
        }

        private void dataGridViewOrdersMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOrdersMain.Rows[dataGridViewOrdersMain.CurrentCell.RowIndex].Cells[4].Value.ToString() == "В ожидании")
            {
                btnAddEditOrder.IconChar = FontAwesome.Sharp.IconChar.Edit;
                dataMode = DataMode.Edit;
            }
            else
            {
                btnAddEditOrder.IconChar = FontAwesome.Sharp.IconChar.Plus;
                dataMode = DataMode.Add;
            }
            connection.Open();
            query = $"select UNP from Suppliers where Name = N'{dataGridViewOrdersMain.Rows[dataGridViewOrdersMain.CurrentCell.RowIndex].Cells[5].Value}'";
            cmd = new SqlCommand(query, connection);
            currentSupplierUNP = cmd.ExecuteScalar().ToString();
            connection.Close();
        }

        #endregion

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrdersMain.Rows[dataGridViewOrdersMain.CurrentCell.RowIndex].Cells[4].Value.ToString() == "В ожидании")
            {
                connection.Open();
                query = $"update Orders set Status = N'Заказан' where Order_ID = '{dataGridViewOrdersMain.Rows[dataGridViewOrdersMain.CurrentCell.RowIndex].Cells[0].Value}'";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                reader.Close();
                connection.Close();
                RefreshMainOrders(defaultMainQuery);
            }
            else
            {
                AlertForm alert = new AlertForm();
                alert.showAlert("Заказ не находится в ожидании!", AlertForm.alertType.Error);
            }
        }

        private void btnSaveOrder_ClickAsync(object sender, EventArgs e)
        {
            if (dataGridViewOrdersMain.RowCount < 1)
            {
                return;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            var file = new FileInfo(saveFileDialog1.FileName);
            var order = GetSetupData();
            SaveExcelFile(order, file);
            AlertForm alert = new AlertForm();
            alert.showAlert("Файл сохранен!", AlertForm.alertType.Success);
        }

        private void SaveExcelFile(List<OrderModel> order, FileInfo file)
        {
            DeleteIfExists(file);

            var package = new ExcelPackage(file);

            var ws = package.Workbook.Worksheets.Add("MainReport");

            var range = ws.Cells["A7"].LoadFromCollection(order, true);
            range.AutoFitColumns();

            // Formats the header
            connection.Open();

            query = $"Select Name + ' ' + Surname + ' ' + Patronymic from users where userTypeID = 2";
            cmd = new SqlCommand(query, connection);
            string storeDirectorFullName = cmd.ExecuteScalar().ToString();

            query = $"Select OrderDate from Orders where Order_ID = '{dataGridViewOrdersMain.Rows[dataGridViewOrdersMain.CurrentCell.RowIndex].Cells[0].Value}'";
            cmd = new SqlCommand(query, connection);
            string orderDate = cmd.ExecuteScalar().ToString();

            query = $"Select DeliveryDate from Orders where Order_ID = '{dataGridViewOrdersMain.Rows[dataGridViewOrdersMain.CurrentCell.RowIndex].Cells[0].Value}'";
            cmd = new SqlCommand(query, connection);
            string deliveryDate = cmd.ExecuteScalar().ToString();

            query = $"Select Name from Store_information";
            cmd = new SqlCommand(query, connection);
            string storeName = cmd.ExecuteScalar().ToString();

            query = $"Select WarehouseAddress from Store_information";
            cmd = new SqlCommand(query, connection);
            string warehouseAddress = cmd.ExecuteScalar().ToString();

            connection.Close();


            ws.Cells["A1"].Value = storeDirectorFullName;
            ws.Cells["A1:I1"].Merge = true;
            ws.Column(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

            ws.Cells["A2"].Value = "Заказ №" + order[1].Номер;
            ws.Cells["A2:I2"].Merge = true;
            ws.Column(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

            ws.Cells["A3"].Value = "Дата заказа:" + orderDate + " Дата поставки: " + deliveryDate;
            ws.Cells["A3:I3"].Merge = true;
            ws.Column(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

            ws.Cells["A4"].Value = "Заказчик: " + storeName;
            ws.Cells["A4:I4"].Merge = true;
            ws.Column(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

            ws.Cells["A5"].Value = "Поставка в место хранения: " + warehouseAddress;
            ws.Cells["A5:I5"].Merge = true;
            ws.Column(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

            ws.Cells["A6"].Value = "Поставщик: " + dataGridViewOrdersMain.Rows[dataGridViewOrdersMain.CurrentCell.RowIndex].Cells[5].Value;
            ws.Cells["A6:I6"].Merge = true;
            ws.Column(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            

            ws.Row(1).Style.Font.Size = 9;
            ws.Row(1).Height = 10.5;
            ws.Row(2).Height = 18.75;
            ws.Row(2).Style.Font.Bold = true;
            ws.Row(2).Style.Font.Size = 10;
            ws.Row(2).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Row(2).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            ws.Row(2).Style.Font.Name = "Arial";
            ws.Row(7).Height = 33;
            ws.Row(7).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Row(7).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            ws.Row(7).Style.Font.Bold = true;
            ws.Cells["A7:I7"].Style.Border.BorderAround(ExcelBorderStyle.Medium);
            ws.Cells["A7:I7"].Style.Border.Left.Style = ExcelBorderStyle.Medium;
            ws.Cells["A7:I7"].Style.Border.Right.Style = ExcelBorderStyle.Medium;

            package.SaveAsync();
            package.Dispose();

         //   file.Delete();
        }

        private void DeleteIfExists(FileInfo file)
        {
            if (file.Exists)
            {
                file.Delete();
            }
        }

        private List<OrderModel> GetSetupData()
        {
            

            connection.Open();

            List<OrderModel> output = new List<OrderModel>();
            int id, PeacesPerBox;
            string Article, Barcode, Name, UnitOfMeasure;
            decimal Price, Quantity, Sum;

            query = $"Select * from OrdersFullView where Order_ID = {dataGridViewOrdersMain.Rows[dataGridViewOrdersMain.CurrentCell.RowIndex].Cells[0].Value}";
            SqlCommand command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                    Article = reader.GetString(1);
                    Barcode = reader.GetString(2);
                    Name = reader.GetString(3);
                    UnitOfMeasure = reader.GetString(4);
                    Quantity = reader.GetInt32(5);
                    PeacesPerBox = reader.GetInt32(6);
                    Price = reader.GetDecimal(7);
                    Sum = Quantity * Price;
                    OrderModel order = new OrderModel() 
                    { 
                        Номер = id, 
                        Артикул = Article, 
                        Штрих_код = Barcode, 
                        Имя = Name, 
                        Ед_изм = UnitOfMeasure,
                        Количество = Quantity,
                        Шт_в_коробке = PeacesPerBox, 
                        Цена = Price,
                        Сумма = Sum
                    };
                    output.Add(order);
                }
            }
            reader.Close();
            connection.Close();
            return output;
        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrdersMain.RowCount < 1)
            {
                return;
            }
            connection.Open();
            query = $"Select EmailLogin from Store_information";
            cmd = new SqlCommand(query, connection);
            string login = cmd.ExecuteScalar().ToString();

            query = $"Select EmailPassword from Store_information";
            cmd = new SqlCommand(query, connection);
            string password = cmd.ExecuteScalar().ToString();

            query = $"Select Name from Store_information";
            cmd = new SqlCommand(query, connection);
            string name = cmd.ExecuteScalar().ToString();

            query = $"Select Email from Suppliers where UNP = {currentSupplierUNP}";
            cmd = new SqlCommand(query, connection);
            string supplierEmail = cmd.ExecuteScalar().ToString();

            connection.Close();
            SmtpClient client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = login,
                    Password = password,
                }
            };

            MailAddress fromEmail = new MailAddress(login, name);
            MailAddress toEmail = new MailAddress(supplierEmail, "Someone");

            StringBuilder mailText = new StringBuilder();
            mailText.AppendLine("Тема:	Заказ поставщику №" + dataGridViewOrdersMain.Rows[dataGridViewOrdersMain.CurrentCell.RowIndex].Cells[0].Value);
            mailText.AppendLine("Дата: " + DateTime.Now);
            mailText.AppendLine("От: " + login);
            mailText.AppendLine("Кому: " + supplierEmail);
            mailText.AppendLine("ЗДРАВСТВУЙТЕ! Примите, пожалуйста, заявку.");

            MailMessage message = new MailMessage()
            {
                From = fromEmail,
                Subject = supplierEmail,
                Body = mailText.ToString()
            };
            message.To.Add(toEmail);
            var file = new FileInfo("Order.xlsx");
            
            var order = GetSetupData();
            SaveExcelFile(order, file);
            message.Attachments.Add(new Attachment("Order.xlsx"));

            client.SendCompleted += Client_SendCompleted;
            client.SendMailAsync(message);
        }

        private void Client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                AlertForm alert = new AlertForm();
                alert.showAlert(e.Error.Message, AlertForm.alertType.Error);
                return;
            }
            else
            {
                AlertForm alert = new AlertForm();
                alert.showAlert("Успешно отправлено!", AlertForm.alertType.Success);
            }
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            dataGridViewOrdersMain.ClearSelection();
            btnAddEditOrder.IconChar = FontAwesome.Sharp.IconChar.Plus;
            dataMode = DataMode.Add;
        }
    }
}
