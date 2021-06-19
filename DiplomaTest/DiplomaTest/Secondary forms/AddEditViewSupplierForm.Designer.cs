
namespace DiplomaTest.Secondary_forms
{
    partial class AddEditViewSupplierForm
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
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.lblModeUserTitle = new System.Windows.Forms.Label();
            this.gunaDragControl3 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.iconCurrentMode = new FontAwesome.Sharp.IconButton();
            this.btnMaximizeRestore = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.btnConfirm = new FontAwesome.Sharp.IconButton();
            this.pnlData = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxWebsite = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxUNP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.lblModeUserTitle;
            // 
            // lblModeUserTitle
            // 
            this.lblModeUserTitle.AutoSize = true;
            this.lblModeUserTitle.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblModeUserTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.lblModeUserTitle.Location = new System.Drawing.Point(33, 8);
            this.lblModeUserTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModeUserTitle.Name = "lblModeUserTitle";
            this.lblModeUserTitle.Size = new System.Drawing.Size(117, 14);
            this.lblModeUserTitle.TabIndex = 1;
            this.lblModeUserTitle.Text = "Operation + user name";
            // 
            // gunaDragControl3
            // 
            this.gunaDragControl3.TargetControl = this.panelHeader;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Controls.Add(this.lblModeUserTitle);
            this.panelHeader.Controls.Add(this.iconCurrentMode);
            this.panelHeader.Controls.Add(this.btnMaximizeRestore);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(592, 30);
            this.panelHeader.TabIndex = 29;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(31)))), ((int)(((byte)(77)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 25;
            this.btnExit.Location = new System.Drawing.Point(562, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(2, 4, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // iconCurrentMode
            // 
            this.iconCurrentMode.FlatAppearance.BorderSize = 0;
            this.iconCurrentMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.iconCurrentMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.iconCurrentMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCurrentMode.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentMode.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.iconCurrentMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentMode.IconSize = 24;
            this.iconCurrentMode.Location = new System.Drawing.Point(3, 3);
            this.iconCurrentMode.Margin = new System.Windows.Forms.Padding(2);
            this.iconCurrentMode.Name = "iconCurrentMode";
            this.iconCurrentMode.Size = new System.Drawing.Size(24, 24);
            this.iconCurrentMode.TabIndex = 0;
            this.iconCurrentMode.UseVisualStyleBackColor = true;
            // 
            // btnMaximizeRestore
            // 
            this.btnMaximizeRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizeRestore.FlatAppearance.BorderSize = 0;
            this.btnMaximizeRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizeRestore.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizeRestore.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(31)))), ((int)(((byte)(77)))));
            this.btnMaximizeRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizeRestore.IconSize = 25;
            this.btnMaximizeRestore.Location = new System.Drawing.Point(532, 0);
            this.btnMaximizeRestore.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximizeRestore.Name = "btnMaximizeRestore";
            this.btnMaximizeRestore.Padding = new System.Windows.Forms.Padding(2, 3, 0, 0);
            this.btnMaximizeRestore.Size = new System.Drawing.Size(30, 30);
            this.btnMaximizeRestore.TabIndex = 3;
            this.btnMaximizeRestore.UseVisualStyleBackColor = true;
            this.btnMaximizeRestore.Click += new System.EventHandler(this.btnMaximizeRestore_Click);
            this.btnMaximizeRestore.MouseEnter += new System.EventHandler(this.btnMaximizeRestore_MouseEnter);
            this.btnMaximizeRestore.MouseLeave += new System.EventHandler(this.btnMaximizeRestore_MouseLeave);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(31)))), ((int)(((byte)(77)))));
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 25;
            this.btnMinimize.Location = new System.Drawing.Point(502, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(2, 3, 0, 0);
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.iconCurrentMode;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.btnConfirm.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnConfirm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.btnConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfirm.IconSize = 40;
            this.btnConfirm.Location = new System.Drawing.Point(153, 215);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(264, 41);
            this.btnConfirm.TabIndex = 25;
            this.btnConfirm.Text = "Подтвердить действие";
            this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.pnlData.Controls.Add(this.textBoxEmail);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Controls.Add(this.textBoxPhoneNumber);
            this.pnlData.Controls.Add(this.textBoxAddress);
            this.pnlData.Controls.Add(this.textBoxWebsite);
            this.pnlData.Controls.Add(this.textBoxName);
            this.pnlData.Controls.Add(this.textBoxUNP);
            this.pnlData.Controls.Add(this.label7);
            this.pnlData.Controls.Add(this.label8);
            this.pnlData.Controls.Add(this.label5);
            this.pnlData.Controls.Add(this.label6);
            this.pnlData.Controls.Add(this.label4);
            this.pnlData.Controls.Add(this.btnConfirm);
            this.pnlData.Location = new System.Drawing.Point(11, 46);
            this.pnlData.Margin = new System.Windows.Forms.Padding(2);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(570, 270);
            this.pnlData.TabIndex = 30;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(107)))), ((int)(((byte)(119)))));
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.textBoxEmail.Location = new System.Drawing.Point(125, 171);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(433, 27);
            this.textBoxEmail.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.label1.Location = new System.Drawing.Point(2, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 27);
            this.label1.TabIndex = 37;
            this.label1.Text = "E-mail:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(107)))), ((int)(((byte)(119)))));
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(125, 107);
            this.textBoxPhoneNumber.Mask = "+375 (999) 000-00-00";
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(433, 27);
            this.textBoxPhoneNumber.TabIndex = 35;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(107)))), ((int)(((byte)(119)))));
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.textBoxAddress.Location = new System.Drawing.Point(125, 139);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.Size = new System.Drawing.Size(433, 27);
            this.textBoxAddress.TabIndex = 29;
            // 
            // textBoxWebsite
            // 
            this.textBoxWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWebsite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(107)))), ((int)(((byte)(119)))));
            this.textBoxWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxWebsite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.textBoxWebsite.Location = new System.Drawing.Point(125, 75);
            this.textBoxWebsite.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWebsite.Name = "textBoxWebsite";
            this.textBoxWebsite.ReadOnly = true;
            this.textBoxWebsite.Size = new System.Drawing.Size(433, 27);
            this.textBoxWebsite.TabIndex = 28;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(107)))), ((int)(((byte)(119)))));
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.textBoxName.Location = new System.Drawing.Point(125, 43);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(433, 27);
            this.textBoxName.TabIndex = 27;
            // 
            // textBoxUNP
            // 
            this.textBoxUNP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUNP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(107)))), ((int)(((byte)(119)))));
            this.textBoxUNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxUNP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.textBoxUNP.Location = new System.Drawing.Point(125, 11);
            this.textBoxUNP.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUNP.Name = "textBoxUNP";
            this.textBoxUNP.ReadOnly = true;
            this.textBoxUNP.Size = new System.Drawing.Size(433, 27);
            this.textBoxUNP.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.label7.Location = new System.Drawing.Point(2, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 27);
            this.label7.TabIndex = 34;
            this.label7.Text = "Адрес:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 18F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.label8.Location = new System.Drawing.Point(2, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 27);
            this.label8.TabIndex = 33;
            this.label8.Text = "Телефон:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.label5.Location = new System.Drawing.Point(2, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 27);
            this.label5.TabIndex = 32;
            this.label5.Text = "Вебсайт:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.label6.Location = new System.Drawing.Point(2, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 27);
            this.label6.TabIndex = 31;
            this.label6.Text = "Название:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.label4.Location = new System.Drawing.Point(2, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 27);
            this.label4.TabIndex = 30;
            this.label4.Text = "УНП:";
            // 
            // AddEditViewSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(592, 327);
            this.ControlBox = false;
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.panelHeader);
            this.MaximumSize = new System.Drawing.Size(608, 343);
            this.MinimumSize = new System.Drawing.Size(608, 343);
            this.Name = "AddEditViewSupplierForm";
            this.Load += new System.EventHandler(this.AddEditForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private System.Windows.Forms.Label lblModeUserTitle;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl3;
        private System.Windows.Forms.Panel panelHeader;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton iconCurrentMode;
        private FontAwesome.Sharp.IconButton btnMaximizeRestore;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private FontAwesome.Sharp.IconButton btnConfirm;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.MaskedTextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxWebsite;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxUNP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label1;
    }
}