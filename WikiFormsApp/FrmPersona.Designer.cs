
namespace WikiFormsApp
{
    partial class FrmPersona
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbVity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPersontype = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtgPersons = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.perIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perLastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perCtyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perPetIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClean = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(761, 259);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 45);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbVity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbPersontype);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(49, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 181);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento de personas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ciudad:";
            // 
            // cmbVity
            // 
            this.cmbVity.FormattingEnabled = true;
            this.cmbVity.Location = new System.Drawing.Point(460, 43);
            this.cmbVity.Name = "cmbVity";
            this.cmbVity.Size = new System.Drawing.Size(210, 21);
            this.cmbVity.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de persona:";
            // 
            // cmbPersontype
            // 
            this.cmbPersontype.FormattingEnabled = true;
            this.cmbPersontype.Location = new System.Drawing.Point(117, 122);
            this.cmbPersontype.Name = "cmbPersontype";
            this.cmbPersontype.Size = new System.Drawing.Size(210, 21);
            this.cmbPersontype.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(117, 85);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(210, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 20);
            this.txtName.TabIndex = 0;
            // 
            // dtgPersons
            // 
            this.dtgPersons.AllowUserToAddRows = false;
            this.dtgPersons.AllowUserToDeleteRows = false;
            this.dtgPersons.AutoGenerateColumns = false;
            this.dtgPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIdDataGridViewTextBoxColumn,
            this.perNameDataGridViewTextBoxColumn,
            this.perLastnameDataGridViewTextBoxColumn,
            this.perCtyIdDataGridViewTextBoxColumn,
            this.perPetIdDataGridViewTextBoxColumn});
            this.dtgPersons.DataSource = this.personBindingSource;
            this.dtgPersons.Location = new System.Drawing.Point(49, 346);
            this.dtgPersons.Name = "dtgPersons";
            this.dtgPersons.ReadOnly = true;
            this.dtgPersons.Size = new System.Drawing.Size(1221, 373);
            this.dtgPersons.TabIndex = 16;
            this.dtgPersons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPerson_CellClick);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(761, 141);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(83, 45);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Agregar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // perIdDataGridViewTextBoxColumn
            // 
            this.perIdDataGridViewTextBoxColumn.DataPropertyName = "perId";
            this.perIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.perIdDataGridViewTextBoxColumn.Name = "perIdDataGridViewTextBoxColumn";
            this.perIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perNameDataGridViewTextBoxColumn
            // 
            this.perNameDataGridViewTextBoxColumn.DataPropertyName = "perName";
            this.perNameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.perNameDataGridViewTextBoxColumn.Name = "perNameDataGridViewTextBoxColumn";
            this.perNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perLastnameDataGridViewTextBoxColumn
            // 
            this.perLastnameDataGridViewTextBoxColumn.DataPropertyName = "perLastname";
            this.perLastnameDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.perLastnameDataGridViewTextBoxColumn.Name = "perLastnameDataGridViewTextBoxColumn";
            this.perLastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perCtyIdDataGridViewTextBoxColumn
            // 
            this.perCtyIdDataGridViewTextBoxColumn.DataPropertyName = "perCtyId";
            this.perCtyIdDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.perCtyIdDataGridViewTextBoxColumn.Name = "perCtyIdDataGridViewTextBoxColumn";
            this.perCtyIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perPetIdDataGridViewTextBoxColumn
            // 
            this.perPetIdDataGridViewTextBoxColumn.DataPropertyName = "perPetId";
            this.perPetIdDataGridViewTextBoxColumn.HeaderText = "Tipo persona";
            this.perPetIdDataGridViewTextBoxColumn.Name = "perPetIdDataGridViewTextBoxColumn";
            this.perPetIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(WikiAPI.Models.Person);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(761, 195);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(83, 45);
            this.btnClean.TabIndex = 18;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // FrmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 842);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgPersons);
            this.Controls.Add(this.btnInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPersona";
            this.Text = "FrmPersona";
            this.Load += new System.EventHandler(this.FrmPerson_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dtgPersons;
        private System.Windows.Forms.Button btnInsert;
        public System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPersontype;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perLastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perCtyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perPetIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClean;
    }
}