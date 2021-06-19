using DiplomaTest.Child_forms;
using DiplomaTest.Child_froms;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

#pragma warning disable IDE1006 //Подавить проверку стилей именования

namespace DiplomaTest.Main_forms
{
    public partial class DirectorMenu : Form
    {
        #region Variables

        private IconButton currentBtn;
        private Button currentSubMenuBtn;
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


        #endregion

        //Constructor
        public DirectorMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel
            {
                Size = new Size(7, 55)
            };
            panelMenu.Controls.Add(leftBorderBtn);
            CloseSubMenus();
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Black;
                currentBtn.ForeColor = LightGray;
                currentBtn.IconColor = LightGray;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }

        private void CloseSubMenus()
        {
            panelStaffSubmenu.Visible = false;
            panelAnalysisSubmenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                CloseSubMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
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
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
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

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelStaffSubmenu);
            ActivateButton(sender, Green);
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelAnalysisSubmenu);
            ActivateButton(sender, Green);
        }

        

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                Reset();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            DisableSubMenuButton();
            CloseSubMenus();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(11, 232, 129);
            lblChildFormTitle.Text = "Главная";
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        private void DisableSubMenuButton()
        {
            if (currentSubMenuBtn != null)
            {
                currentSubMenuBtn.BackColor = Gray;
                currentSubMenuBtn.ForeColor = Black;
                currentSubMenuBtn.FlatAppearance.MouseOverBackColor = Gray;
                currentSubMenuBtn.FlatAppearance.MouseDownBackColor = Gray;
            }
        }

        private void ActivateSubMenuButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableSubMenuButton();
                currentSubMenuBtn = (Button)senderBtn;
                if (currentSubMenuBtn.ForeColor != color)
                {
                    //Button
                    currentSubMenuBtn.ForeColor = color;
                    //Icon Current Child Form
                    iconCurrentChildForm.IconChar = currentBtn.IconChar;
                    iconCurrentChildForm.IconColor = color;
                    lblChildFormTitle.Text = currentSubMenuBtn.Text;
                }
                else
                {
                    DisableSubMenuButton();
                }
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

        private void btnDeputy_Click(object sender, EventArgs e)
        {
            ActivateButton(this.btnStaff, Green);
            ActivateSubMenuButton(sender, Cyan);
            OpenChildForm(new DeputyDirectors());
        }

        private void btnCommodityExperts_Click(object sender, EventArgs e)
        {
            ActivateButton(this.btnStaff, Green);
            ActivateSubMenuButton(sender, Cyan);
            OpenChildForm(new CommodityExperts());
        }

        private void btnManagers_Click(object sender, EventArgs e)
        {
            ActivateButton(this.btnStaff, Green);
            ActivateSubMenuButton(sender, Cyan);
            OpenChildForm(new Managers());
        }

        private void btnCashiers_Click(object sender, EventArgs e)
        {
            ActivateButton(this.btnStaff, Green);
            ActivateSubMenuButton(sender, Cyan);
            OpenChildForm(new Cashiers());
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            ActivateButton(this.btnAnalysis, Green);
            ActivateSubMenuButton(sender, Cyan);
            OpenChildForm(new ReceiptsStat());
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            ActivateButton(this.btnAnalysis, Green);
            ActivateSubMenuButton(sender, Cyan);
            OpenChildForm(new ImplementationStat());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ActivateButton(this.btnAnalysis, Green);
            ActivateSubMenuButton(sender, Cyan);
            OpenChildForm(new Orders(2, Orders.DataMode.View));
        }

        private void btnExpired_Click(object sender, EventArgs e)
        {
            ActivateButton(this.btnAnalysis, Green);
            ActivateSubMenuButton(sender, Cyan);
            OpenChildForm(new StaleProducts());
        }


        private void btnShopInfo_Click(object sender, EventArgs e)
        {
            CloseSubMenus();
            ActivateButton(sender, Green);
            OpenChildForm(new StoreInfo());
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            CloseSubMenus();
            ActivateButton(sender, Green);
            OpenChildForm(new Suppliers());
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

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            CloseSubMenus();
            ActivateButton(sender, Green);
            OpenChildForm(new Remains());
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
