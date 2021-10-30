
namespace WikiFormsApp
{
    partial class FrmProduct
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProcutType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtgProducts = new System.Windows.Forms.DataGridView();
            this.prdPdtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsert = new System.Windows.Forms.Button();
            this.prdIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdEntryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdSupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1116, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 45);
            this.button1.TabIndex = 19;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(1116, 245);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 45);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbSupplier);
            this.groupBox1.Controls.Add(this.dtpEntryDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCost);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbProcutType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Location = new System.Drawing.Point(49, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1043, 181);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento de producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(713, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Proveedor:";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(778, 47);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(210, 21);
            this.cmbSupplier.TabIndex = 12;
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntryDate.Location = new System.Drawing.Point(464, 82);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(210, 20);
            this.dtpEntryDate.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha ingreso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stock:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(464, 43);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(210, 20);
            this.txtStock.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Costo:";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(126, 122);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(210, 20);
            this.txtCost.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(126, 79);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(210, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de producto:";
            // 
            // cmbProcutType
            // 
            this.cmbProcutType.FormattingEnabled = true;
            this.cmbProcutType.Location = new System.Drawing.Point(464, 117);
            this.cmbProcutType.Name = "cmbProcutType";
            this.cmbProcutType.Size = new System.Drawing.Size(210, 21);
            this.cmbProcutType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripcion:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(126, 43);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(210, 20);
            this.txtDescription.TabIndex = 0;
            // 
            // dtgProducts
            // 
            this.dtgProducts.AllowUserToAddRows = false;
            this.dtgProducts.AllowUserToDeleteRows = false;
            this.dtgProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProducts.AutoGenerateColumns = false;
            this.dtgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prdIdDataGridViewTextBoxColumn,
            this.prdDescriptionDataGridViewTextBoxColumn,
            this.prdPriceDataGridViewTextBoxColumn,
            this.prdCostDataGridViewTextBoxColumn,
            this.prdStockDataGridViewTextBoxColumn,
            this.prdEntryDateDataGridViewTextBoxColumn,
            this.prdPdtId,
            this.prdSupIdDataGridViewTextBoxColumn});
            this.dtgProducts.DataSource = this.productBindingSource;
            this.dtgProducts.Location = new System.Drawing.Point(49, 346);
            this.dtgProducts.Name = "dtgProducts";
            this.dtgProducts.ReadOnly = true;
            this.dtgProducts.Size = new System.Drawing.Size(1221, 373);
            this.dtgProducts.TabIndex = 17;
            this.dtgProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProduct_CellClick);
            // 
            // prdPdtId
            // 
            this.prdPdtId.DataPropertyName = "prdPdtId";
            this.prdPdtId.HeaderText = "Tipo de producto";
            this.prdPdtId.Name = "prdPdtId";
            this.prdPdtId.ReadOnly = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(1116, 123);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(83, 45);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Agregar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // prdIdDataGridViewTextBoxColumn
            // 
            this.prdIdDataGridViewTextBoxColumn.DataPropertyName = "prdId";
            this.prdIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.prdIdDataGridViewTextBoxColumn.Name = "prdIdDataGridViewTextBoxColumn";
            this.prdIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prdDescriptionDataGridViewTextBoxColumn
            // 
            this.prdDescriptionDataGridViewTextBoxColumn.DataPropertyName = "prdDescription";
            this.prdDescriptionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.prdDescriptionDataGridViewTextBoxColumn.Name = "prdDescriptionDataGridViewTextBoxColumn";
            this.prdDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prdPriceDataGridViewTextBoxColumn
            // 
            this.prdPriceDataGridViewTextBoxColumn.DataPropertyName = "prdPrice";
            this.prdPriceDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.prdPriceDataGridViewTextBoxColumn.Name = "prdPriceDataGridViewTextBoxColumn";
            this.prdPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prdCostDataGridViewTextBoxColumn
            // 
            this.prdCostDataGridViewTextBoxColumn.DataPropertyName = "prdCost";
            this.prdCostDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.prdCostDataGridViewTextBoxColumn.Name = "prdCostDataGridViewTextBoxColumn";
            this.prdCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prdStockDataGridViewTextBoxColumn
            // 
            this.prdStockDataGridViewTextBoxColumn.DataPropertyName = "prdStock";
            this.prdStockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.prdStockDataGridViewTextBoxColumn.Name = "prdStockDataGridViewTextBoxColumn";
            this.prdStockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prdEntryDateDataGridViewTextBoxColumn
            // 
            this.prdEntryDateDataGridViewTextBoxColumn.DataPropertyName = "prdEntryDate";
            this.prdEntryDateDataGridViewTextBoxColumn.HeaderText = "Fecha de ingreso";
            this.prdEntryDateDataGridViewTextBoxColumn.Name = "prdEntryDateDataGridViewTextBoxColumn";
            this.prdEntryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prdSupIdDataGridViewTextBoxColumn
            // 
            this.prdSupIdDataGridViewTextBoxColumn.DataPropertyName = "prdSupId";
            this.prdSupIdDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.prdSupIdDataGridViewTextBoxColumn.Name = "prdSupIdDataGridViewTextBoxColumn";
            this.prdSupIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WikiFormsApp.Models.Product);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 842);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgProducts);
            this.Controls.Add(this.btnInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProcutType;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DataGridView dtgProducts;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdEntryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdPdtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdSupIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPrice;
    }
}