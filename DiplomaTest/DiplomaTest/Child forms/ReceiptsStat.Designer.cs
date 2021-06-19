
namespace DiplomaTest.Child_forms
{
    partial class ReceiptsStat
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
            this.lblFormName = new System.Windows.Forms.Label();
            this.dataGridViewOrdersMain = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rjDatePicker2 = new DiplomaTest.RJControls.RJDatePicker();
            this.rjDatePicker1 = new DiplomaTest.RJControls.RJDatePicker();
            this.diplomaTestDataSetBillsOfLadingMain = new DiplomaTest.DiplomaTestDataSetBillsOfLadingMain();
            this.diplomaTestDataSetBillsOfLadingMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billsOfLadingMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billsOfLadingMainTableAdapter = new DiplomaTest.DiplomaTestDataSetBillsOfLadingMainTableAdapters.BillsOfLadingMainTableAdapter();
            this.billOfLadingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdersMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaTestDataSetBillsOfLadingMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaTestDataSetBillsOfLadingMainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsOfLadingMainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFormName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.lblFormName.Location = new System.Drawing.Point(11, 9);
            this.lblFormName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(346, 32);
            this.lblFormName.TabIndex = 58;
            this.lblFormName.Text = "Статистика поступлений";
            // 
            // dataGridViewOrdersMain
            // 
            this.dataGridViewOrdersMain.AllowUserToAddRows = false;
            this.dataGridViewOrdersMain.AllowUserToDeleteRows = false;
            this.dataGridViewOrdersMain.AllowUserToResizeColumns = false;
            this.dataGridViewOrdersMain.AllowUserToResizeRows = false;
            this.dataGridViewOrdersMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrdersMain.AutoGenerateColumns = false;
            this.dataGridViewOrdersMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrdersMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOrdersMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(107)))), ((int)(((byte)(119)))));
            this.dataGridViewOrdersMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOrdersMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(95)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrdersMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrdersMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrdersMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billOfLadingIDDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn});
            this.dataGridViewOrdersMain.DataSource = this.billsOfLadingMainBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(107)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(95)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrdersMain.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOrdersMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewOrdersMain.EnableHeadersVisualStyles = false;
            this.dataGridViewOrdersMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.dataGridViewOrdersMain.Location = new System.Drawing.Point(17, 84);
            this.dataGridViewOrdersMain.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewOrdersMain.Name = "dataGridViewOrdersMain";
            this.dataGridViewOrdersMain.ReadOnly = true;
            this.dataGridViewOrdersMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(95)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrdersMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOrdersMain.RowHeadersVisible = false;
            this.dataGridViewOrdersMain.RowTemplate.Height = 24;
            this.dataGridViewOrdersMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrdersMain.Size = new System.Drawing.Size(857, 545);
            this.dataGridViewOrdersMain.TabIndex = 59;
            this.dataGridViewOrdersMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrdersMain_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 61;
            this.label1.Text = "От";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.label2.Location = new System.Drawing.Point(193, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 62;
            this.label2.Text = "до";
            // 
            // rjDatePicker2
            // 
            this.rjDatePicker2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDatePicker2.BorderSize = 0;
            this.rjDatePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rjDatePicker2.Location = new System.Drawing.Point(233, 41);
            this.rjDatePicker2.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker2.Name = "rjDatePicker2";
            this.rjDatePicker2.Size = new System.Drawing.Size(135, 35);
            this.rjDatePicker2.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.rjDatePicker2.TabIndex = 64;
            this.rjDatePicker2.TextColor = System.Drawing.Color.White;
            this.rjDatePicker2.ValueChanged += new System.EventHandler(this.rjDatePicker2_ValueChanged);
            // 
            // rjDatePicker1
            // 
            this.rjDatePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDatePicker1.BorderSize = 0;
            this.rjDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rjDatePicker1.Location = new System.Drawing.Point(53, 41);
            this.rjDatePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker1.Name = "rjDatePicker1";
            this.rjDatePicker1.Size = new System.Drawing.Size(135, 35);
            this.rjDatePicker1.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.rjDatePicker1.TabIndex = 63;
            this.rjDatePicker1.TextColor = System.Drawing.Color.White;
            this.rjDatePicker1.Value = new System.DateTime(2021, 6, 2, 19, 46, 58, 0);
            this.rjDatePicker1.ValueChanged += new System.EventHandler(this.rjDatePicker1_ValueChanged);
            // 
            // diplomaTestDataSetBillsOfLadingMain
            // 
            this.diplomaTestDataSetBillsOfLadingMain.DataSetName = "DiplomaTestDataSetBillsOfLadingMain";
            this.diplomaTestDataSetBillsOfLadingMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diplomaTestDataSetBillsOfLadingMainBindingSource
            // 
            this.diplomaTestDataSetBillsOfLadingMainBindingSource.DataSource = this.diplomaTestDataSetBillsOfLadingMain;
            this.diplomaTestDataSetBillsOfLadingMainBindingSource.Position = 0;
            // 
            // billsOfLadingMainBindingSource
            // 
            this.billsOfLadingMainBindingSource.DataMember = "BillsOfLadingMain";
            this.billsOfLadingMainBindingSource.DataSource = this.diplomaTestDataSetBillsOfLadingMainBindingSource;
            // 
            // billsOfLadingMainTableAdapter
            // 
            this.billsOfLadingMainTableAdapter.ClearBeforeFill = true;
            // 
            // billOfLadingIDDataGridViewTextBoxColumn
            // 
            this.billOfLadingIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.billOfLadingIDDataGridViewTextBoxColumn.DataPropertyName = "BillOfLading_ID";
            this.billOfLadingIDDataGridViewTextBoxColumn.HeaderText = "Номер ТТН";
            this.billOfLadingIDDataGridViewTextBoxColumn.Name = "billOfLadingIDDataGridViewTextBoxColumn";
            this.billOfLadingIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.billOfLadingIDDataGridViewTextBoxColumn.Width = 106;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Width = 114;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "Дата поставки";
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryDateDataGridViewTextBoxColumn.Width = 117;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "Принял";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ReceiptsStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(885, 640);
            this.Controls.Add(this.rjDatePicker2);
            this.Controls.Add(this.rjDatePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewOrdersMain);
            this.Controls.Add(this.lblFormName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceiptsStat";
            this.Text = "ReceiptsStat";
            this.Load += new System.EventHandler(this.ReceiptsStat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdersMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaTestDataSetBillsOfLadingMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaTestDataSetBillsOfLadingMainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsOfLadingMainBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.DataGridView dataGridViewOrdersMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private RJControls.RJDatePicker rjDatePicker1;
        private RJControls.RJDatePicker rjDatePicker2;
        private System.Windows.Forms.BindingSource diplomaTestDataSetBillsOfLadingMainBindingSource;
        private DiplomaTestDataSetBillsOfLadingMain diplomaTestDataSetBillsOfLadingMain;
        private System.Windows.Forms.BindingSource billsOfLadingMainBindingSource;
        private DiplomaTestDataSetBillsOfLadingMainTableAdapters.BillsOfLadingMainTableAdapter billsOfLadingMainTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billOfLadingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
    }
}