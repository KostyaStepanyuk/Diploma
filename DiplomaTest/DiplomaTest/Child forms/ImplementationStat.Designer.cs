
namespace DiplomaTest.Child_forms
{
    partial class ImplementationStat
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOrdersMain = new System.Windows.Forms.DataGridView();
            this.billsOfLadingSecondaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diplomaTestDataSetBillsOfLadingSecondaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diplomaTestDataSetBillsOfLadingSecondary = new DiplomaTest.DiplomaTestDataSetBillsOfLadingSecondary();
            this.lblFormName = new System.Windows.Forms.Label();
            this.billsOfLadingSecondaryTableAdapter = new DiplomaTest.DiplomaTestDataSetBillsOfLadingSecondaryTableAdapters.BillsOfLadingSecondaryTableAdapter();
            this.rjDatePicker2 = new DiplomaTest.RJControls.RJDatePicker();
            this.rjDatePicker1 = new DiplomaTest.RJControls.RJDatePicker();
            this.diplomaTestDataSetCheque = new DiplomaTest.DiplomaTestDataSetCheque();
            this.chequeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chequeTableAdapter = new DiplomaTest.DiplomaTestDataSetChequeTableAdapters.ChequeTableAdapter();
            this.chequeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofsaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdersMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsOfLadingSecondaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaTestDataSetBillsOfLadingSecondaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaTestDataSetBillsOfLadingSecondary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaTestDataSetCheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chequeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.label2.Location = new System.Drawing.Point(182, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 68;
            this.label2.Text = "до";
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
            this.label1.TabIndex = 67;
            this.label1.Text = "От";
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
            this.chequeIDDataGridViewTextBoxColumn,
            this.dateofsaleDataGridViewTextBoxColumn,
            this.purchaseamountDataGridViewTextBoxColumn});
            this.dataGridViewOrdersMain.DataSource = this.chequeBindingSource;
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
            this.dataGridViewOrdersMain.TabIndex = 66;
            this.dataGridViewOrdersMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrdersMain_CellDoubleClick_1);
            // 
            // billsOfLadingSecondaryBindingSource
            // 
            this.billsOfLadingSecondaryBindingSource.DataMember = "BillsOfLadingSecondary";
            this.billsOfLadingSecondaryBindingSource.DataSource = this.diplomaTestDataSetBillsOfLadingSecondaryBindingSource;
            // 
            // diplomaTestDataSetBillsOfLadingSecondaryBindingSource
            // 
            this.diplomaTestDataSetBillsOfLadingSecondaryBindingSource.DataSource = this.diplomaTestDataSetBillsOfLadingSecondary;
            this.diplomaTestDataSetBillsOfLadingSecondaryBindingSource.Position = 0;
            // 
            // diplomaTestDataSetBillsOfLadingSecondary
            // 
            this.diplomaTestDataSetBillsOfLadingSecondary.DataSetName = "DiplomaTestDataSetBillsOfLadingSecondary";
            this.diplomaTestDataSetBillsOfLadingSecondary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFormName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.lblFormName.Location = new System.Drawing.Point(11, 9);
            this.lblFormName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(332, 32);
            this.lblFormName.TabIndex = 65;
            this.lblFormName.Text = "Статистика реализации";
            // 
            // billsOfLadingSecondaryTableAdapter
            // 
            this.billsOfLadingSecondaryTableAdapter.ClearBeforeFill = true;
            // 
            // rjDatePicker2
            // 
            this.rjDatePicker2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDatePicker2.BorderSize = 0;
            this.rjDatePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rjDatePicker2.Location = new System.Drawing.Point(222, 41);
            this.rjDatePicker2.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker2.Name = "rjDatePicker2";
            this.rjDatePicker2.Size = new System.Drawing.Size(135, 35);
            this.rjDatePicker2.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.rjDatePicker2.TabIndex = 70;
            this.rjDatePicker2.TextColor = System.Drawing.Color.White;
            // 
            // rjDatePicker1
            // 
            this.rjDatePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDatePicker1.BorderSize = 0;
            this.rjDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rjDatePicker1.Location = new System.Drawing.Point(42, 41);
            this.rjDatePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker1.Name = "rjDatePicker1";
            this.rjDatePicker1.Size = new System.Drawing.Size(135, 35);
            this.rjDatePicker1.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.rjDatePicker1.TabIndex = 69;
            this.rjDatePicker1.TextColor = System.Drawing.Color.White;
            this.rjDatePicker1.Value = new System.DateTime(2021, 6, 2, 19, 46, 58, 0);
            // 
            // diplomaTestDataSetCheque
            // 
            this.diplomaTestDataSetCheque.DataSetName = "DiplomaTestDataSetCheque";
            this.diplomaTestDataSetCheque.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chequeBindingSource
            // 
            this.chequeBindingSource.DataMember = "Cheque";
            this.chequeBindingSource.DataSource = this.diplomaTestDataSetCheque;
            // 
            // chequeTableAdapter
            // 
            this.chequeTableAdapter.ClearBeforeFill = true;
            // 
            // chequeIDDataGridViewTextBoxColumn
            // 
            this.chequeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.chequeIDDataGridViewTextBoxColumn.DataPropertyName = "Cheque_ID";
            this.chequeIDDataGridViewTextBoxColumn.HeaderText = "Номер чека";
            this.chequeIDDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.chequeIDDataGridViewTextBoxColumn.Name = "chequeIDDataGridViewTextBoxColumn";
            this.chequeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.chequeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateofsaleDataGridViewTextBoxColumn
            // 
            this.dateofsaleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateofsaleDataGridViewTextBoxColumn.DataPropertyName = "Date_of_sale";
            this.dateofsaleDataGridViewTextBoxColumn.HeaderText = "Дата продажи";
            this.dateofsaleDataGridViewTextBoxColumn.Name = "dateofsaleDataGridViewTextBoxColumn";
            this.dateofsaleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchaseamountDataGridViewTextBoxColumn
            // 
            this.purchaseamountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.purchaseamountDataGridViewTextBoxColumn.DataPropertyName = "Purchase_amount";
            this.purchaseamountDataGridViewTextBoxColumn.HeaderText = "Сумма покупки";
            this.purchaseamountDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.purchaseamountDataGridViewTextBoxColumn.Name = "purchaseamountDataGridViewTextBoxColumn";
            this.purchaseamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.purchaseamountDataGridViewTextBoxColumn.Width = 150;
            // 
            // ImplementationStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(885, 640);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewOrdersMain);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.rjDatePicker2);
            this.Controls.Add(this.rjDatePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImplementationStat";
            this.Text = "ImplementationStat";
            this.Load += new System.EventHandler(this.ImplementationStat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdersMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsOfLadingSecondaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaTestDataSetBillsOfLadingSecondaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaTestDataSetBillsOfLadingSecondary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaTestDataSetCheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chequeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOrdersMain;
        private System.Windows.Forms.BindingSource billsOfLadingSecondaryBindingSource;
        private System.Windows.Forms.BindingSource diplomaTestDataSetBillsOfLadingSecondaryBindingSource;
        private DiplomaTestDataSetBillsOfLadingSecondary diplomaTestDataSetBillsOfLadingSecondary;
        private System.Windows.Forms.Label lblFormName;
        private DiplomaTestDataSetBillsOfLadingSecondaryTableAdapters.BillsOfLadingSecondaryTableAdapter billsOfLadingSecondaryTableAdapter;
        private RJControls.RJDatePicker rjDatePicker2;
        private RJControls.RJDatePicker rjDatePicker1;
        private DiplomaTestDataSetCheque diplomaTestDataSetCheque;
        private System.Windows.Forms.BindingSource chequeBindingSource;
        private DiplomaTestDataSetChequeTableAdapters.ChequeTableAdapter chequeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofsaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseamountDataGridViewTextBoxColumn;
    }
}