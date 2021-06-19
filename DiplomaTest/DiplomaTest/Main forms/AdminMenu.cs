using DiplomaTest.Child_froms;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

#pragma warning disable IDE1006 //Подавить проверку стилей именования

namespace DiplomaTest.Main_forms
{
    public partial class AdminMenu : Form
    {
        #region Variables

        private IconButton currentBtn;
        private Button currentSubMenuBtn;
        private readonly Panel leftBorderBtn;
        private Form currentChildForm;

        private readonly Color Black = Color.FromArgb(30, 39, 46),
                               Gray = Color.FromArgb(128, 142, 155),
                               LightGray = Color.FromArgb(210, 218, 226),
                               Green = Color.FromArgb(5, 196, 107),
                               Cyan = Color.FromArgb(52, 231, 228);

        #endregion


        //Конструктор
        public AdminMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel
            {
                Size = new Size(7, 55)
            };
            panelMenu.Controls.Add(leftBorderBtn);
            CloseSubMenus();
        }


        #region Methods

        private void CloseSubMenus()
        {
            panelUsersSubmenu.Visible = false;
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

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Black;
                currentBtn.ForeColor = LightGray;
                currentBtn.IconColor = LightGray;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
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

        private void btnUsers_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Green);
            ShowSubMenu(panelUsersSubmenu);
        }

        private void btnSuppliers_Click(object sender, System.EventArgs e)
        {
            DisableSubMenuButton();
            ActivateButton(sender, Green);
            OpenChildForm(new Suppliers());
        }

        private void btnHome_Click(object sender, System.EventArgs e)
        {
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

        private void btnManagers_Click(object sender, EventArgs e)
        {
            ActivateButton(this.btnUsers, Green);
            ActivateSubMenuButton(sender, Cyan);
            OpenChildForm(new Managers());
        }

        private void btnCommodityExperts_Click(object sender, EventArgs e)
        {
            ActivateButton(this.btnUsers, Green);
            ActivateSubMenuButton(sender, Cyan);
            OpenChildForm(new CommodityExperts());
        }

        #region WindowControl
        private void btnExit_Click(object sender, EventArgs e)
        {
            Form newForm = Application.OpenForms[0];
            newForm.Show();
            this.Close();
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.IconColor = Color.FromArgb(255, 94, 87);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.IconColor = Color.White;
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

        private void btnDirector_Click(object sender, EventArgs e)
        {
            ActivateButton(this.btnUsers, Green);
            ActivateSubMenuButton(sender, Cyan);
            OpenChildForm(new Directors());
        }

        private void btnDeputy_Click(object sender, EventArgs e)
        {
            ActivateButton(this.btnUsers, Green);
            ActivateSubMenuButton(sender, Cyan);
            OpenChildForm(new DeputyDirectors());
        }

        private void btnCashiers_Click(object sender, EventArgs e)
        {
            ActivateButton(this.btnUsers, Green);
            ActivateSubMenuButton(sender, Cyan);
            OpenChildForm(new Cashiers());
        }

        private void btnMaximizeRestore_MouseEnter(object sender, EventArgs e)
        {
            btnMaximizeRestore.IconColor = Color.FromArgb(87, 95, 207);
        }

        private void btnMaximizeRestore_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizeRestore.IconColor = Color.White;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.IconColor = Color.FromArgb(255, 168, 1);
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.IconColor = Color.White;
        }
        #endregion

        #endregion
    }
}