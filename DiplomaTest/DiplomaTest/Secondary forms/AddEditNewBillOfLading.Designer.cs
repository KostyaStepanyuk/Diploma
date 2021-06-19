
namespace DiplomaTest.Secondary_forms
{
    partial class AddEditNewBillOfLading
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblModeUserTitle = new System.Windows.Forms.Label();
            this.iconCurrentMode = new FontAwesome.Sharp.IconButton();
            this.btnMaximizeRestore = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.ordersViewSecondaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diplomaTestDataSetOrdersViewSecondary = new DiplomaTest.DiplomaTestDataSetOrdersViewSecondary();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.comboBoxOrders = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl3 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.ordersViewSecondaryTableAdapter = new DiplomaTest.DiplomaTestDataSetOrdersViewSecondaryTableAdapters.OrdersViewSecondaryTableAdapter();
            this.dataGridViewBillOfLading = new System.Windows.Forms.DataGridView();
            this.billOfLadingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billsOfLadingSecondaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diplomaTestDataSetBillsOfLadingSecondary = new DiplomaTest.DiplomaTestDataSetBillsOfLadingSecondary();
            this.billsOfLadingSecondaryTableAdapter = new DiplomaTest.DiplomaTestDataSetBillsOfLadingSecondaryTableAdapters.BillsOfLadingSecondaryTableAdapter();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewSecondaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaTestDataSetOrdersViewSecondary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillOfLading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsOfLadingSecondaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaTestDataSetBillsOfLadingSecondary)).BeginInit();
            this.SuspendLayout();
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
            this.panelHeader.Size = new System.Drawing.Size(1063, 30);
            this.panelHeader.TabIndex = 30;
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
            this.btnExit.Location = new System.Drawing.Point(1033, 0);
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
            this.btnMaximizeRestore.Location = new System.Drawing.Point(1003, 0);
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
            this.btnMinimize.Location = new System.Drawing.Point(973, 0);
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
            // ordersViewSecondaryBindingSource
            // 
            this.ordersViewSecondaryBindingSource.DataMember = "OrdersViewSecondary";
            this.ordersViewSecondaryBindingSource.DataSource = this.diplomaTestDataSetOrdersViewSecondary;
            // 
            // diplomaTestDataSetOrdersViewSecondary
            // 
            this.diplomaTestDataSetOrdersViewSecondary.DataSetName = "DiplomaTestDataSetOrdersViewSecondary";
            this.diplomaTestDataSetOrdersViewSecondary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 40;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(464, 470);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 41);
            this.btnDelete.TabIndex = 70;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 40;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(326, 470);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 41);
            this.btnAdd.TabIndex = 68;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBoxOrders
            // 
            this.comboBoxOrders.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxOrders.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(107)))), ((int)(((byte)(119)))));
            this.comboBoxOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxOrders.FormattingEnabled = true;
            this.comboBoxOrders.Location = new System.Drawing.Point(90, 34);
            this.comboBoxOrders.Name = "comboBoxOrders";
            this.comboBoxOrders.Size = new System.Drawing.Size(113, 28);
            this.comboBoxOrders.TabIndex = 82;
            this.comboBoxOrders.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrders_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.label5.Location = new System.Drawing.Point(2, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 27);
            this.label5.TabIndex = 81;
            this.label5.Text = "Заказ:";
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.iconCurrentMode;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.lblModeUserTitle;
            // 
            // gunaDragControl3
            // 
            this.gunaDragControl3.TargetControl = this.panelHeader;
            // 
            // ordersViewSecondaryTableAdapter
            // 
            this.ordersViewSecondaryTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewBillOfLading
            // 
            this.dataGridViewBillOfLading.AllowUserToAddRows = false;
            this.dataGridViewBillOfLading.AllowUserToDeleteRows = false;
            this.dataGridViewBillOfLading.AllowUserToResizeColumns = false;
            this.dataGridViewBillOfLading.AllowUserToResizeRows = false;
            this.dataGridViewBillOfLading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBillOfLading.AutoGenerateColumns = false;
            this.dataGridViewBillOfLading.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBillOfLading.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBillOfLading.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(107)))), ((int)(((byte)(119)))));
            this.dataGridViewBillOfLading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBillOfLading.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(95)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBillOfLading.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBillOfLading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBillOfLading.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billOfLadingIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn1,
            this.deliveryDateDataGridViewTextBoxColumn1});
            this.dataGridViewBillOfLading.DataSource = this.billsOfLadingSecondaryBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(107)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(95)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBillOfLading.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBillOfLading.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewBillOfLading.EnableHeadersVisualStyles = false;
            this.dataGridViewBillOfLading.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.dataGridViewBillOfLading.Location = new System.Drawing.Point(7, 67);
            this.dataGridViewBillOfLading.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBillOfLading.Name = "dataGridViewBillOfLading";
            this.dataGridViewBillOfLading.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(95)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBillOfLading.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBillOfLading.RowHeadersVisible = false;
            this.dataGridViewBillOfLading.RowTemplate.Height = 24;
            this.dataGridViewBillOfLading.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBillOfLading.Size = new System.Drawing.Size(1045, 399);
            this.dataGridViewBillOfLading.TabIndex = 84;
            this.dataGridViewBillOfLading.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewBillOfLading_CellBeginEdit);
            this.dataGridViewBillOfLading.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBillOfLading_CellEndEdit);
            // 
            // billOfLadingIDDataGridViewTextBoxColumn
            // 
            this.billOfLadingIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.billOfLadingIDDataGridViewTextBoxColumn.DataPropertyName = "BillOfLading_ID";
            this.billOfLadingIDDataGridViewTextBoxColumn.HeaderText = "Номер ТТН";
            this.billOfLadingIDDataGridViewTextBoxColumn.Name = "billOfLadingIDDataGridViewTextBoxColumn";
            this.billOfLadingIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.billOfLadingIDDataGridViewTextBoxColumn.Width = 65;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Количество";
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            this.quantityDataGridViewTextBoxColumn1.Width = 110;
            // 
            // deliveryDateDataGridViewTextBoxColumn1
            // 
            this.deliveryDateDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.deliveryDateDataGridViewTextBoxColumn1.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn1.HeaderText = "Дата поставки";
            this.deliveryDateDataGridViewTextBoxColumn1.Name = "deliveryDateDataGridViewTextBoxColumn1";
            this.deliveryDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.deliveryDateDataGridViewTextBoxColumn1.Width = 117;
            // 
            // billsOfLadingSecondaryBindingSource
            // 
            this.billsOfLadingSecondaryBindingSource.DataMember = "BillsOfLadingSecondary";
            this.billsOfLadingSecondaryBindingSource.DataSource = this.diplomaTestDataSetBillsOfLadingSecondary;
            // 
            // diplomaTestDataSetBillsOfLadingSecondary
            // 
            this.diplomaTestDataSetBillsOfLadingSecondary.DataSetName = "DiplomaTestDataSetBillsOfLadingSecondary";
            this.diplomaTestDataSetBillsOfLadingSecondary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billsOfLadingSecondaryTableAdapter
            // 
            this.billsOfLadingSecondaryTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 40;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(602, 470);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 41);
            this.btnSave.TabIndex = 85;
            this.btnSave.Text = "Сохранить";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddEditNewBillOfLading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1063, 522);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridViewBillOfLading);
            this.Controls.Add(this.comboBoxOrders);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelHeader);
            this.Name = "AddEditNewBillOfLading";
            this.Load += new System.EventHandler(this.AddEditNewBillOfLading_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewSecondaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaTestDataSetOrdersViewSecondary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillOfLading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsOfLadingSecondaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaTestDataSetBillsOfLadingSecondary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label lblModeUserTitle;
        private FontAwesome.Sharp.IconButton iconCurrentMode;
        private FontAwesome.Sharp.IconButton btnMaximizeRestore;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.ComboBox comboBoxOrders;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl3;
        private DiplomaTestDataSetOrdersViewSecondary diplomaTestDataSetOrdersViewSecondary;
        private System.Windows.Forms.BindingSource ordersViewSecondaryBindingSource;
        private DiplomaTestDataSetOrdersViewSecondaryTableAdapters.OrdersViewSecondaryTableAdapter ordersViewSecondaryTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewBillOfLading;
        private DiplomaTestDataSetBillsOfLadingSecondary diplomaTestDataSetBillsOfLadingSecondary;
        private System.Windows.Forms.BindingSource billsOfLadingSecondaryBindingSource;
        private DiplomaTestDataSetBillsOfLadingSecondaryTableAdapters.BillsOfLadingSecondaryTableAdapter billsOfLadingSecondaryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billOfLadingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn1;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}