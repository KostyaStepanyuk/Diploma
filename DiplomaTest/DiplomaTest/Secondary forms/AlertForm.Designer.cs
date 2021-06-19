
namespace DiplomaTest.Secondary_forms
{
    partial class AlertForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelAlert = new System.Windows.Forms.Label();
            this.iconPictureBoxAlert = new FontAwesome.Sharp.IconPictureBox();
            this.iconButtonAlertClose = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl3 = new Guna.UI.WinForms.GunaDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAlert
            // 
            this.labelAlert.AutoSize = true;
            this.labelAlert.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.labelAlert.Location = new System.Drawing.Point(38, 30);
            this.labelAlert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlert.Name = "labelAlert";
            this.labelAlert.Size = new System.Drawing.Size(182, 32);
            this.labelAlert.TabIndex = 0;
            this.labelAlert.Text = "Message Text";
            // 
            // iconPictureBoxAlert
            // 
            this.iconPictureBoxAlert.BackColor = System.Drawing.Color.DarkRed;
            this.iconPictureBoxAlert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.iconPictureBoxAlert.IconChar = FontAwesome.Sharp.IconChar.Frown;
            this.iconPictureBoxAlert.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.iconPictureBoxAlert.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxAlert.IconSize = 42;
            this.iconPictureBoxAlert.Location = new System.Drawing.Point(4, 28);
            this.iconPictureBoxAlert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconPictureBoxAlert.Name = "iconPictureBoxAlert";
            this.iconPictureBoxAlert.Size = new System.Drawing.Size(42, 42);
            this.iconPictureBoxAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBoxAlert.TabIndex = 1;
            this.iconPictureBoxAlert.TabStop = false;
            // 
            // iconButtonAlertClose
            // 
            this.iconButtonAlertClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonAlertClose.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonAlertClose.FlatAppearance.BorderSize = 0;
            this.iconButtonAlertClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButtonAlertClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButtonAlertClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAlertClose.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButtonAlertClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.iconButtonAlertClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAlertClose.Location = new System.Drawing.Point(250, 25);
            this.iconButtonAlertClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButtonAlertClose.Name = "iconButtonAlertClose";
            this.iconButtonAlertClose.Size = new System.Drawing.Size(37, 40);
            this.iconButtonAlertClose.TabIndex = 2;
            this.iconButtonAlertClose.UseVisualStyleBackColor = false;
            this.iconButtonAlertClose.Click += new System.EventHandler(this.iconButtonNotificationClose_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.labelAlert;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.iconPictureBoxAlert;
            // 
            // gunaDragControl3
            // 
            this.gunaDragControl3.TargetControl = this;
            // 
            // AlertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(292, 86);
            this.Controls.Add(this.iconButtonAlertClose);
            this.Controls.Add(this.iconPictureBoxAlert);
            this.Controls.Add(this.labelAlert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AlertForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxAlert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlert;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxAlert;
        private FontAwesome.Sharp.IconButton iconButtonAlertClose;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl3;
    }
}