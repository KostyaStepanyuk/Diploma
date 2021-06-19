
namespace DiplomaTest.Secondary_forms
{
    partial class NewOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.iconNewOrder = new FontAwesome.Sharp.IconButton();
            this.btnMaximizeRestore = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitOfMeasureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peacesPerBoxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diplomaTestDataSetProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diplomaTestDataSetProducts = new DiplomaTest.DiplomaTestDataSetProducts();
            this.dataGridViewNewOrder = new System.Windows.Forms.DataGridView();
            this.ordersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl3 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.btnAddProduct = new FontAwesome.Sharp.IconPictureBox();
            this.btnAddAllProducts = new FontAwesome.Sharp.IconPictureBox();
            this.btnRemoveProduct = new FontAwesome.Sharp.IconPictureBox();
            this.btnRemoveAllProducts = new FontAwesome.Sharp.IconPictureBox();
            this.productsViewTableAdapter = new DiplomaTest.DiplomaTestDataSetProductsTableAdapters.ProductsViewTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.rjDatePicker1 = new DiplomaTest.RJControls.RJDatePicker();
            this.diplomaTestDataSetOrdersView = new DiplomaTest.DiplomaTestDataSetOrdersView();
            this.diplomaTestDataSetOrdersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersViewSecondaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersViewSecondaryTableAdapter = new DiplomaTest.DiplomaTestDataSetOrdersViewTableAdapters.OrdersViewSecondaryTableAdapter();
            this.productnameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeacesPerBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitOfMeasure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaTestDataSetProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaTestDataSetProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAllProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveAllProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaTestDataSetOrdersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaTestDataSetOrdersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewSecondaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Controls.Add(this.lblOrderNumber);
            this.panelHeader.Controls.Add(this.iconNewOrder);
            this.panelHeader.Controls.Add(this.btnMaximizeRestore);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1149, 30);
            this.panelHeader.TabIndex = 31;
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
            this.btnExit.Location = new System.Drawing.Point(1119, 0);
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
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.lblOrderNumber.Location = new System.Drawing.Point(29, 7);
            this.lblOrderNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(71, 14);
            this.lblOrderNumber.TabIndex = 1;
            this.lblOrderNumber.Text = "Новый заказ";
            // 
            // iconNewOrder
            // 
            this.iconNewOrder.FlatAppearance.BorderSize = 0;
            this.iconNewOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.iconNewOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.iconNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconNewOrder.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iconNewOrder.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.iconNewOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconNewOrder.IconSize = 24;
            this.iconNewOrder.Location = new System.Drawing.Point(3, 3);
            this.iconNewOrder.Margin = new System.Windows.Forms.Padding(2);
            this.iconNewOrder.Name = "iconNewOrder";
            this.iconNewOrder.Size = new System.Drawing.Size(24, 24);
            this.iconNewOrder.TabIndex = 0;
            this.iconNewOrder.UseVisualStyleBackColor = true;
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
            this.btnMaximizeRestore.Location = new System.Drawing.Point(1089, 0);
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
            this.btnMinimize.Location = new System.Drawing.Point(1059, 0);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.label12.Location = new System.Drawing.Point(11, 41);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 21);
            this.label12.TabIndex = 58;
            this.label12.Text = "Поставщик:";
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(107)))), ((int)(((byte)(119)))));
            this.comboBoxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(132, 41);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(423, 21);
            this.comboBoxSupplier.TabIndex = 81;
            this.comboBoxSupplier.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupplier_SelectedIndexChanged);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AllowUserToResizeColumns = false;
            this.dataGridViewProducts.AllowUserToResizeRows = false;
            this.dataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProducts.AutoGenerateColumns = false;
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(107)))), ((int)(((byte)(119)))));
            this.dataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(95)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articleDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.unitOfMeasureDataGridViewTextBoxColumn,
            this.peacesPerBoxDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn});
            this.dataGridViewProducts.DataSource = this.productsViewBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(107)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(95)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewProducts.EnableHeadersVisualStyles = false;
            this.dataGridViewProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.dataGridViewProducts.Location = new System.Drawing.Point(11, 108);
            this.dataGridViewProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(95)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(687, 358);
            this.dataGridViewProducts.TabIndex = 82;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            this.articleDataGridViewTextBoxColumn.ReadOnly = true;
            this.articleDataGridViewTextBoxColumn.Width = 87;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Штрих-код";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.barcodeDataGridViewTextBoxColumn.Width = 99;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitOfMeasureDataGridViewTextBoxColumn
            // 
            this.unitOfMeasureDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.unitOfMeasureDataGridViewTextBoxColumn.DataPropertyName = "UnitOfMeasure";
            this.unitOfMeasureDataGridViewTextBoxColumn.HeaderText = "Ед. изм.";
            this.unitOfMeasureDataGridViewTextBoxColumn.Name = "unitOfMeasureDataGridViewTextBoxColumn";
            this.unitOfMeasureDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitOfMeasureDataGridViewTextBoxColumn.Width = 78;
            // 
            // peacesPerBoxDataGridViewTextBoxColumn
            // 
            this.peacesPerBoxDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.peacesPerBoxDataGridViewTextBoxColumn.DataPropertyName = "PeacesPerBox";
            this.peacesPerBoxDataGridViewTextBoxColumn.HeaderText = "Шт. в коробке";
            this.peacesPerBoxDataGridViewTextBoxColumn.Name = "peacesPerBoxDataGridViewTextBoxColumn";
            this.peacesPerBoxDataGridViewTextBoxColumn.ReadOnly = true;
            this.peacesPerBoxDataGridViewTextBoxColumn.Width = 111;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 65;
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "Отдел";
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            this.departmentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentNameDataGridViewTextBoxColumn.Width = 73;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierNameDataGridViewTextBoxColumn.Width = 104;
            // 
            // productsViewBindingSource
            // 
            this.productsViewBindingSource.DataMember = "ProductsView";
            this.productsViewBindingSource.DataSource = this.diplomaTestDataSetProductsBindingSource;
            // 
            // diplomaTestDataSetProductsBindingSource
            // 
            this.diplomaTestDataSetProductsBindingSource.DataSource = this.diplomaTestDataSetProducts;
            this.diplomaTestDataSetProductsBindingSource.Position = 0;
            // 
            // diplomaTestDataSetProducts
            // 
            this.diplomaTestDataSetProducts.DataSetName = "DiplomaTestDataSetProducts";
            this.diplomaTestDataSetProducts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewNewOrder
            // 
            this.dataGridViewNewOrder.AllowUserToAddRows = false;
            this.dataGridViewNewOrder.AllowUserToDeleteRows = false;
            this.dataGridViewNewOrder.AllowUserToResizeColumns = false;
            this.dataGridViewNewOrder.AllowUserToResizeRows = false;
            this.dataGridViewNewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNewOrder.AutoGenerateColumns = false;
            this.dataGridViewNewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNewOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewNewOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(107)))), ((int)(((byte)(119)))));
            this.dataGridViewNewOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNewOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(95)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNewOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewNewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productnameDataGridViewTextBoxColumn2,
            this.PeacesPerBox,
            this.UnitOfMeasure,
            this.dataGridViewTextBoxColumn1});
            this.dataGridViewNewOrder.DataSource = this.ordersViewSecondaryBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(107)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(95)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNewOrder.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewNewOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewNewOrder.EnableHeadersVisualStyles = false;
            this.dataGridViewNewOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.dataGridViewNewOrder.Location = new System.Drawing.Point(786, 108);
            this.dataGridViewNewOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewNewOrder.Name = "dataGridViewNewOrder";
            this.dataGridViewNewOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(95)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNewOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewNewOrder.RowHeadersVisible = false;
            this.dataGridViewNewOrder.RowTemplate.Height = 24;
            this.dataGridViewNewOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNewOrder.Size = new System.Drawing.Size(352, 358);
            this.dataGridViewNewOrder.TabIndex = 83;
            this.dataGridViewNewOrder.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNewOrder_CellEndEdit);
            // 
            // ordersViewBindingSource
            // 
            this.ordersViewBindingSource.DataMember = "OrdersView";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.label1.Location = new System.Drawing.Point(11, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 84;
            this.label1.Text = "Продукт:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.label2.Location = new System.Drawing.Point(782, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 85;
            this.label2.Text = "Заказ:";
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.panelHeader;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.iconNewOrder;
            // 
            // gunaDragControl3
            // 
            this.gunaDragControl3.TargetControl = this.lblOrderNumber;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddProduct.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnAddProduct.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnAddProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddProduct.IconSize = 50;
            this.btnAddProduct.Location = new System.Drawing.Point(717, 177);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(50, 50);
            this.btnAddProduct.TabIndex = 86;
            this.btnAddProduct.TabStop = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnAddAllProducts
            // 
            this.btnAddAllProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAllProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.btnAddAllProducts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddAllProducts.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.btnAddAllProducts.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnAddAllProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddAllProducts.IconSize = 50;
            this.btnAddAllProducts.Location = new System.Drawing.Point(717, 233);
            this.btnAddAllProducts.Name = "btnAddAllProducts";
            this.btnAddAllProducts.Size = new System.Drawing.Size(50, 50);
            this.btnAddAllProducts.TabIndex = 87;
            this.btnAddAllProducts.TabStop = false;
            this.btnAddAllProducts.Click += new System.EventHandler(this.btnAddAllProducts_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.btnRemoveProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoveProduct.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btnRemoveProduct.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoveProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemoveProduct.IconSize = 50;
            this.btnRemoveProduct.Location = new System.Drawing.Point(717, 299);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(50, 50);
            this.btnRemoveProduct.TabIndex = 88;
            this.btnRemoveProduct.TabStop = false;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnRemoveAllProducts
            // 
            this.btnRemoveAllProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAllProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.btnRemoveAllProducts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoveAllProducts.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.btnRemoveAllProducts.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoveAllProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemoveAllProducts.IconSize = 50;
            this.btnRemoveAllProducts.Location = new System.Drawing.Point(717, 355);
            this.btnRemoveAllProducts.Name = "btnRemoveAllProducts";
            this.btnRemoveAllProducts.Size = new System.Drawing.Size(50, 50);
            this.btnRemoveAllProducts.TabIndex = 89;
            this.btnRemoveAllProducts.TabStop = false;
            this.btnRemoveAllProducts.Click += new System.EventHandler(this.btnRemoveAllProducts_Click);
            // 
            // productsViewTableAdapter
            // 
            this.productsViewTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.label3.Location = new System.Drawing.Point(560, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 21);
            this.label3.TabIndex = 91;
            this.label3.Text = "Дата поставки:";
            // 
            // rjDatePicker1
            // 
            this.rjDatePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDatePicker1.BorderSize = 0;
            this.rjDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rjDatePicker1.Location = new System.Drawing.Point(711, 35);
            this.rjDatePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker1.Name = "rjDatePicker1";
            this.rjDatePicker1.Size = new System.Drawing.Size(200, 35);
            this.rjDatePicker1.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(107)))), ((int)(((byte)(119)))));
            this.rjDatePicker1.TabIndex = 90;
            this.rjDatePicker1.TextColor = System.Drawing.Color.White;
            // 
            // diplomaTestDataSetOrdersView
            // 
            this.diplomaTestDataSetOrdersView.DataSetName = "DiplomaTestDataSetOrdersView";
            this.diplomaTestDataSetOrdersView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diplomaTestDataSetOrdersViewBindingSource
            // 
            this.diplomaTestDataSetOrdersViewBindingSource.DataSource = this.diplomaTestDataSetOrdersView;
            this.diplomaTestDataSetOrdersViewBindingSource.Position = 0;
            // 
            // ordersViewSecondaryBindingSource
            // 
            this.ordersViewSecondaryBindingSource.DataMember = "OrdersViewSecondary";
            this.ordersViewSecondaryBindingSource.DataSource = this.diplomaTestDataSetOrdersViewBindingSource;
            // 
            // ordersViewSecondaryTableAdapter
            // 
            this.ordersViewSecondaryTableAdapter.ClearBeforeFill = true;
            // 
            // productnameDataGridViewTextBoxColumn2
            // 
            this.productnameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productnameDataGridViewTextBoxColumn2.DataPropertyName = "Product_name";
            this.productnameDataGridViewTextBoxColumn2.HeaderText = "Товар";
            this.productnameDataGridViewTextBoxColumn2.Name = "productnameDataGridViewTextBoxColumn2";
            this.productnameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // PeacesPerBox
            // 
            this.PeacesPerBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PeacesPerBox.DataPropertyName = "PeacesPerBox";
            this.PeacesPerBox.HeaderText = "Шт. в коробке";
            this.PeacesPerBox.Name = "PeacesPerBox";
            this.PeacesPerBox.ReadOnly = true;
            this.PeacesPerBox.Width = 65;
            // 
            // UnitOfMeasure
            // 
            this.UnitOfMeasure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UnitOfMeasure.DataPropertyName = "UnitOfMeasure";
            this.UnitOfMeasure.HeaderText = "Ед. изм.";
            this.UnitOfMeasure.Name = "UnitOfMeasure";
            this.UnitOfMeasure.ReadOnly = true;
            this.UnitOfMeasure.Width = 45;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn1.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1149, 477);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rjDatePicker1);
            this.Controls.Add(this.btnRemoveAllProducts);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnAddAllProducts);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewNewOrder);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.comboBoxSupplier);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panelHeader);
            this.MinimumSize = new System.Drawing.Size(16, 61);
            this.Name = "NewOrder";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaTestDataSetProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaTestDataSetProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAllProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveAllProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaTestDataSetOrdersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaTestDataSetOrdersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersViewSecondaryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label lblOrderNumber;
        private FontAwesome.Sharp.IconButton iconNewOrder;
        private FontAwesome.Sharp.IconButton btnMaximizeRestore;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.DataGridView dataGridViewNewOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl3;
        private FontAwesome.Sharp.IconPictureBox btnAddProduct;
        private FontAwesome.Sharp.IconPictureBox btnAddAllProducts;
        private FontAwesome.Sharp.IconPictureBox btnRemoveProduct;
        private FontAwesome.Sharp.IconPictureBox btnRemoveAllProducts;
  //      private System.Windows.Forms.BindingSource diplomaTestDataSetOrdersViewBindingSource;
   //     private DiplomaTestDataSetOrdersView diplomaTestDataSetOrdersView;
        private System.Windows.Forms.BindingSource ordersViewBindingSource;
     //   private DiplomaTestDataSetOrdersViewTableAdapters.OrdersViewTableAdapter ordersViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn peacesPerBoxDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitOfMeasureDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource diplomaTestDataSetProductsBindingSource;
        private DiplomaTestDataSetProducts diplomaTestDataSetProducts;
        private System.Windows.Forms.BindingSource productsViewBindingSource;
        private DiplomaTestDataSetProductsTableAdapters.ProductsViewTableAdapter productsViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitOfMeasureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peacesPerBoxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private RJControls.RJDatePicker rjDatePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource diplomaTestDataSetOrdersViewBindingSource;
        private DiplomaTestDataSetOrdersView diplomaTestDataSetOrdersView;
        private System.Windows.Forms.BindingSource ordersViewSecondaryBindingSource;
        private DiplomaTestDataSetOrdersViewTableAdapters.OrdersViewSecondaryTableAdapter ordersViewSecondaryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeacesPerBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitOfMeasure;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}