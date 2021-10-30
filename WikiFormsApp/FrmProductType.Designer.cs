
namespace WikiFormsApp
{
    partial class FrmProductType
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.dtgProductTypes = new System.Windows.Forms.DataGridView();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pdtIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdtDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Location = new System.Drawing.Point(57, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 181);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento de tipo de producto";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(516, 130);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 45);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(516, 14);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(83, 45);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Agregar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(77, 43);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(210, 20);
            this.txtType.TabIndex = 0;
            // 
            // dtgProductTypes
            // 
            this.dtgProductTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProductTypes.AutoGenerateColumns = false;
            this.dtgProductTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pdtIdDataGridViewTextBoxColumn,
            this.pdtDescriptionDataGridViewTextBoxColumn});
            this.dtgProductTypes.DataSource = this.productTypeBindingSource;
            this.dtgProductTypes.Location = new System.Drawing.Point(57, 365);
            this.dtgProductTypes.Name = "dtgProductTypes";
            this.dtgProductTypes.Size = new System.Drawing.Size(1221, 373);
            this.dtgProductTypes.TabIndex = 10;
            this.dtgProductTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProductTypes_CellClick);
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataSource = typeof(WikiAPI.Models.ProductType);
            // 
            // pdtIdDataGridViewTextBoxColumn
            // 
            this.pdtIdDataGridViewTextBoxColumn.DataPropertyName = "pdtId";
            this.pdtIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.pdtIdDataGridViewTextBoxColumn.Name = "pdtIdDataGridViewTextBoxColumn";
            // 
            // pdtDescriptionDataGridViewTextBoxColumn
            // 
            this.pdtDescriptionDataGridViewTextBoxColumn.DataPropertyName = "pdtDescription";
            this.pdtDescriptionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.pdtDescriptionDataGridViewTextBoxColumn.Name = "pdtDescriptionDataGridViewTextBoxColumn";
            // 
            // FrmProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 881);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgProductTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProductType";
            this.Text = "FrmProductType";
            this.Load += new System.EventHandler(this.FrmProductType_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        public System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.DataGridView dtgProductTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdtIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdtDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
    }
}