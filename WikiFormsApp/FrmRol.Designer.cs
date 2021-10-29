
namespace WikiFormsApp
{
    partial class FrmRol
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
            this.dtgRoles = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rolIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoles)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgRoles
            // 
            this.dtgRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgRoles.AutoGenerateColumns = false;
            this.dtgRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rolIdDataGridViewTextBoxColumn,
            this.rolNombreDataGridViewTextBoxColumn});
            this.dtgRoles.DataSource = this.rolBindingSource;
            this.dtgRoles.Location = new System.Drawing.Point(28, 253);
            this.dtgRoles.Name = "dtgRoles";
            this.dtgRoles.Size = new System.Drawing.Size(528, 258);
            this.dtgRoles.TabIndex = 0;
            this.dtgRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dlgRole_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRol);
            this.groupBox1.Location = new System.Drawing.Point(28, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento de roles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rol:";
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(56, 43);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(210, 20);
            this.txtRol.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(471, 74);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(83, 45);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Agregar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(471, 137);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 45);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rolIdDataGridViewTextBoxColumn
            // 
            this.rolIdDataGridViewTextBoxColumn.DataPropertyName = "rolId";
            this.rolIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.rolIdDataGridViewTextBoxColumn.Name = "rolIdDataGridViewTextBoxColumn";
            // 
            // rolNombreDataGridViewTextBoxColumn
            // 
            this.rolNombreDataGridViewTextBoxColumn.DataPropertyName = "rolNombre";
            this.rolNombreDataGridViewTextBoxColumn.HeaderText = "Rol";
            this.rolNombreDataGridViewTextBoxColumn.Name = "rolNombreDataGridViewTextBoxColumn";
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataSource = typeof(WikiAPI.Models.Rol);
            // 
            // FrmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 523);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgRoles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRol";
            this.Text = "Rol";
            this.Load += new System.EventHandler(this.FrmRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox txtRol;
    }
}