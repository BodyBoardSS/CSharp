
namespace WikiFormsApp
{
    partial class FrmCity
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtgCities = new System.Windows.Forms.DataGridView();
            this.ctyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(460, 124);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 45);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(460, 73);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(83, 45);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Agregar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(15, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 181);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento de ciudades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 20);
            this.txtName.TabIndex = 0;
            // 
            // dtgCities
            // 
            this.dtgCities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCities.AutoGenerateColumns = false;
            this.dtgCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ctyIdDataGridViewTextBoxColumn,
            this.ctyNameDataGridViewTextBoxColumn});
            this.dtgCities.DataSource = this.cityBindingSource;
            this.dtgCities.Location = new System.Drawing.Point(12, 254);
            this.dtgCities.Name = "dtgCities";
            this.dtgCities.Size = new System.Drawing.Size(552, 244);
            this.dtgCities.TabIndex = 4;
            this.dtgCities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dlgCities_CellClick);
            // 
            // ctyIdDataGridViewTextBoxColumn
            // 
            this.ctyIdDataGridViewTextBoxColumn.DataPropertyName = "ctyId";
            this.ctyIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ctyIdDataGridViewTextBoxColumn.Name = "ctyIdDataGridViewTextBoxColumn";
            // 
            // ctyNameDataGridViewTextBoxColumn
            // 
            this.ctyNameDataGridViewTextBoxColumn.DataPropertyName = "ctyName";
            this.ctyNameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.ctyNameDataGridViewTextBoxColumn.Name = "ctyNameDataGridViewTextBoxColumn";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(WikiAPI.Models.City);
            // 
            // FrmCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 523);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgCities);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCity";
            this.Text = "FrmCity";
            this.Load += new System.EventHandler(this.FrmCity_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dtgCities;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cityBindingSource;
    }
}