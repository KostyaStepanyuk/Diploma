using DiplomaTest.Child_forms;
using DiplomaTest.Secondary_froms;
using FontAwesome.Sharp;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

#pragma warning disable IDE1006 //Подавить проверку стилей именования

namespace DiplomaTest.Main_forms
{
    public partial class CommodityExpertMenu : Form
    {
        #region Variables

        private readonly string connectionString = @"Server=tcp:ubicakrovi.database.windows.net,1433;Initial Catalog=DiplomaTest;Persist Security Info=False;User ID=firetruck;Password=74Rjcnzy;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection connection;
        private SqlDataReader reader = null;
        private SqlCommand cmd;
        private string query;
        private IconButton currentBtn;
        private IconButton currentSubMenuBtn;
        private readonly Panel leftBorderBtn;
        private Form currentChildForm;

        private readonly Color Black = Color.FromArgb(30, 39, 46),
                                DarkLightGrey = Color.FromArgb(85, 94, 101),
                                Gray = Color.FromArgb(128, 142, 155),
                                LightGray = Color.FromArgb(210, 218, 226),
                                Green = Color.FromArgb(5, 196, 107),
                                Cyan = Color.FromArgb(52, 231, 228),
                                Red = Color.FromArgb(243, 31, 77),
                                White = Color.FromArgb(250, 242, 243);

        private readonly int currentUserID;


        #endregion


        //Конструктор
        public CommodityExpertMenu(int userID)
        {
            InitializeComponent();
            currentUserID = userID;
            leftBorderBtn = new Panel
            {
                Size = new Size(7, 55)
            };
            panelMenu.Controls.Add(leftBorderBtn);
            CloseSubMenus();
        }


        #region Methods


        #region Default methods

        private void btnGuide_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelGuideSubmenu);
            ActivateButton(sender, Green);
            DisableSubMenuButton();
        }
        private void CommodityExpertMenu_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);

        }

    
        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            DisableSubMenuButton();
            ActivateButton(sender, Green);
            OpenChildForm(new Orders(currentUserID, Orders.DataMode.Add));
        }

        private bool IsAlreadyAdded(string productName)
        {
            query = $"Select count(*) from Products where Name = N'{productName}'";
            cmd = new SqlCommand(query, connection);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            var file = new FileInfo(openFileDialog1.FileName);
            List<ProductModel> productsFromExcel = LoadExcelFile(file);

            connection.Open();
            foreach (var p in productsFromExcel)
            {
                if(!IsAlreadyAdded(p.Name))
                {
                    query = $"Insert into Products " +
                    $"(Name, Price, Supplier_UNP, Barcode, VAT, Department_ID, Article, UnitOfMeasure, PeacesPerBox) " +
                    $"values " +
                    $"(N'{p.Name}', " +
                    $"N'{p.Price}', " +
                    $"N'{p.Supplier_UNP}', " +
                    $"N'{p.Barcode}', " +
                    $"N'{p.VAT}', " +
                    $"N'{p.Department_ID}', " +
                    $"N'{p.Article}', " +
                    $"N'{p.UnitOfMeasure}', " +
                    $"N'{p.PeacesPerBox}')";
                    cmd = new SqlCommand(query, connection);
                    reader = cmd.ExecuteReader();
                    reader.Close();
                }
            }
            connection.Close();
        }

        private List<ProductModel> LoadExcelFile(FileInfo file)
        {
            List<ProductModel> output = new List<ProductModel>();

            var package = new ExcelPackage(file);

            package.LoadAsync(file);

            var ws = package.Workbook.Worksheets[0];

            int row = 8;
            int col = 1;

            while (string.IsNullOrWhiteSpace(ws.Cells[row, col].Value?.ToString()) == false)
            {
                ProductModel p = new ProductModel();
                p.Name = ws.Cells[row, col].Value.ToString();
                p.Price = decimal.Parse(ws.Cells[row, col + 1].Value.ToString());
                p.Supplier_UNP = ws.Cells[row, col + 2].Value.ToString();
                p.Barcode = ws.Cells[row, col + 3].Value.ToString();
                p.VAT = int.Parse(ws.Cells[row, col + 4].Value.ToString());
                p.Department_ID = int.Parse(ws.Cells[row, col + 5].Value.ToString());
                p.Article = ws.Cells[row, col + 6].Value.ToString();
                p.UnitOfMeasure = ws.Cells[row, col + 7].Value.ToString();
                p.PeacesPerBox = int.Parse(ws.Cells[row, col + 8].Value.ToString());
                output.Add(p);
                row += 1;
            }
            package.Dispose();

            return output;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActivateButton(this.btnGuide, Green);
            ActivateSubMenuButton(sender, Cyan);
            OpenChildForm(new Products());
        }

        private void btnSupliers_Click(object sender, EventArgs e)
        {
            ActivateButton(this.btnGuide, Green);
            ActivateSubMenuButton(sender, Cyan);
            OpenChildForm(new Suppliers2());
        }






        private void panelMenu_Click(object sender, EventArgs e)
        {
            DisableButton();
        }

        #endregion

        #region Independent methods

        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                //CloseSubMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void CloseSubMenus()
        {
            panelGuideSubmenu.Visible = false;
        }

        private void DisableSubMenuButton()
        {
            if (currentSubMenuBtn != null)
            {
                currentSubMenuBtn.BackColor = Gray;
                currentSubMenuBtn.ForeColor = Black;
                currentSubMenuBtn.IconColor = Black;
                currentSubMenuBtn.FlatAppearance.MouseOverBackColor = Gray;
                currentSubMenuBtn.FlatAppearance.MouseDownBackColor = Gray;
            }
        }

        private void Reset()
        {
            DisableButton();
            DisableSubMenuButton();
            CloseSubMenus();
            //leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(11, 232, 129);
            lblChildFormTitle.Text = "Главная";
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //currentBtn.BackColor = Black;
                currentBtn.ForeColor = LightGray;
                currentBtn.IconColor = LightGray;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                leftBorderBtn.Visible = false;
            }
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                //Button
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                lblChildFormTitle.Text = currentBtn.Text;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateSubMenuButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableSubMenuButton();
                currentSubMenuBtn = (IconButton)senderBtn;
                if (currentSubMenuBtn.ForeColor != color)
                {
                    //Button
                    currentSubMenuBtn.ForeColor = color;
                    currentSubMenuBtn.IconColor = color;
                    //Icon Current Child Form
                    iconCurrentChildForm.IconChar = currentSubMenuBtn.IconChar;
                    iconCurrentChildForm.IconColor = color;
                    lblChildFormTitle.Text = currentSubMenuBtn.Text;
                }
                else
                {
                    DisableSubMenuButton();
                }
            }
        }

        private void btnBillOfLading_Click(object sender, EventArgs e)
        {
            DisableSubMenuButton();
            ActivateButton(sender, Green);
            OpenChildForm(new BillsOfLading(currentUserID));
        }

        private void btnRemains_Click(object sender, EventArgs e)
        {
            DisableSubMenuButton();
            ActivateButton(sender, Green);
            OpenChildForm(new Remains());
        }

        private void btnDisbursementBillOfLading_Click(object sender, EventArgs e)
        {
            DisableSubMenuButton();
            ActivateButton(sender, Green);
            OpenChildForm(new DisbursementBillOfLading(currentUserID));
        }

        #endregion
        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpAndManual help = new HelpAndManual();
            help.Show();
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


        #endregion
    }
}