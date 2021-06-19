using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaTest.Secondary_froms
{
    public partial class HelpAndManual : Form
    {
        private readonly Color Black = Color.FromArgb(30, 39, 46),
                                DarkLightGrey = Color.FromArgb(85, 94, 101),
                                Gray = Color.FromArgb(128, 142, 155),
                                LightGray = Color.FromArgb(210, 218, 226),
                                Green = Color.FromArgb(5, 196, 107),
                                Cyan = Color.FromArgb(52, 231, 228),
                                Red = Color.FromArgb(243, 31, 77),
                                White = Color.FromArgb(250, 242, 243);
        public HelpAndManual()
        {
            InitializeComponent();
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
    }
}
