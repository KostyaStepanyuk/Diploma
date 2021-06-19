using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaTest.Secondary_forms
{
    public partial class AlertForm : Form
    {
        public enum alertAction
        {
            wait,
            close
        }

        alertAction action = new alertAction();

        public enum alertType
        {
            Success,
            Warning,
            Info,
            Error
        }

        public AlertForm()
        {
            InitializeComponent();
        }

        public void showAlert(string message, alertType type)
        {
            switch (type)
            {
                case alertType.Error:
                    this.iconPictureBoxAlert.IconChar = FontAwesome.Sharp.IconChar.Frown;
                    this.iconPictureBoxAlert.BackColor = Color.DarkRed;
                    this.BackColor = Color.DarkRed;
                    break;
                case alertType.Success:
                    this.iconPictureBoxAlert.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                    this.iconPictureBoxAlert.BackColor = Color.SeaGreen;
                    this.BackColor = Color.SeaGreen;
                    break;
                case alertType.Warning:
                    this.iconPictureBoxAlert.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
                    this.iconPictureBoxAlert.BackColor = Color.DarkOrange;
                    this.BackColor = Color.DarkOrange;
                    break;
                case alertType.Info:
                    this.iconPictureBoxAlert.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
                    this.iconPictureBoxAlert.BackColor = Color.RoyalBlue;
                    this.BackColor = Color.RoyalBlue;
                    break;
            }
            this.labelAlert.Text = message;
            this.Width = labelAlert.Width + 160;
            if (this.Width < 400)
                this.Width = 400;
            this.Opacity = 1;
            this.Show();
            this.action = alertAction.wait;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }

        private void iconButtonNotificationClose_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            this.action = alertAction.close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case alertAction.wait:
                    timer1.Interval = 2000;
                    action = alertAction.close;
                    break;
                case alertAction.close:
                    timer1.Interval = 5;
                    this.Opacity -= 0.1;
                    if (base.Opacity == 0.0)
                    {
                        this.Close();
                    }
                    break;
            }
        }
    }
}
