
namespace WikiFormsApp
{
    partial class FrmSupplier
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPersona = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dtgDocumentTypes = new System.Windows.Forms.DataGridView();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supTradenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supPerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDocumentTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbPersona);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Location = new System.Drawing.Point(49, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 181);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento de tipo de documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Persona:";
            // 
            // cmbPersona
            // 
            this.cmbPersona.FormattingEnabled = true;
            this.cmbPersona.Location = new System.Drawing.Point(126, 80);
            this.cmbPersona.Name = "cmbPersona";
            this.cmbPersona.Size = new System.Drawing.Size(210, 21);
            this.cmbPersona.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Comercial:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(126, 43);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(210, 20);
            this.txtType.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(660, 259);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 45);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(660, 137);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(83, 45);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Agregar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dtgDocumentTypes
            // 
            this.dtgDocumentTypes.AllowUserToAddRows = false;
            this.dtgDocumentTypes.AllowUserToDeleteRows = false;
            this.dtgDocumentTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDocumentTypes.AutoGenerateColumns = false;
            this.dtgDocumentTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDocumentTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supIdDataGridViewTextBoxColumn,
            this.supTradenameDataGridViewTextBoxColumn,
            this.supPerIdDataGridViewTextBoxColumn});
            this.dtgDocumentTypes.DataSource = this.supplierBindingSource;
            this.dtgDocumentTypes.Location = new System.Drawing.Point(49, 346);
            this.dtgDocumentTypes.Name = "dtgDocumentTypes";
            this.dtgDocumentTypes.ReadOnly = true;
            this.dtgDocumentTypes.Size = new System.Drawing.Size(1221, 373);
            this.dtgDocumentTypes.TabIndex = 12;
            this.dtgDocumentTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSupplier_CellClick);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(WikiAPI.Models.Supplier);
            // 
            // supIdDataGridViewTextBoxColumn
            // 
            this.supIdDataGridViewTextBoxColumn.DataPropertyName = "supId";
            this.supIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.supIdDataGridViewTextBoxColumn.Name = "supIdDataGridViewTextBoxColumn";
            this.supIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supTradenameDataGridViewTextBoxColumn
            // 
            this.supTradenameDataGridViewTextBoxColumn.DataPropertyName = "supTradename";
            this.supTradenameDataGridViewTextBoxColumn.HeaderText = "Nombre Comercial";
            this.supTradenameDataGridViewTextBoxColumn.Name = "supTradenameDataGridViewTextBoxColumn";
            this.supTradenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supPerIdDataGridViewTextBoxColumn
            // 
            this.supPerIdDataGridViewTextBoxColumn.DataPropertyName = "supPerId";
            this.supPerIdDataGridViewTextBoxColumn.HeaderText = "Person";
            this.supPerIdDataGridViewTextBoxColumn.Name = "supPerIdDataGridViewTextBoxColumn";
            this.supPerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 842);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgDocumentTypes);
            this.Controls.Add(this.btnInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSupplier";
            this.Text = "FrmSupplier";
            this.Load += new System.EventHandler(this.FrmSuppliere_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDocumentTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dtgDocumentTypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn supIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supTradenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supPerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.Button button1;
    }
}