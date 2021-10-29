
namespace WikiFormsApp
{
    partial class FrmPersonType
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
            this.txtType = new System.Windows.Forms.TextBox();
            this.dtgPersonTypes = new System.Windows.Forms.DataGridView();
            this.personTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personTypeBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Location = new System.Drawing.Point(35, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 181);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento de tipo de persona";
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
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(77, 43);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(210, 20);
            this.txtType.TabIndex = 0;
            // 
            // dtgPersonTypes
            // 
            this.dtgPersonTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPersonTypes.AutoGenerateColumns = false;
            this.dtgPersonTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPersonTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.petIdDataGridViewTextBoxColumn,
            this.petDescriptionDataGridViewTextBoxColumn});
            this.dtgPersonTypes.DataSource = this.personTypeBindingSource;
            this.dtgPersonTypes.Location = new System.Drawing.Point(35, 338);
            this.dtgPersonTypes.Name = "dtgPersonTypes";
            this.dtgPersonTypes.Size = new System.Drawing.Size(1221, 373);
            this.dtgPersonTypes.TabIndex = 8;
            this.dtgPersonTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPersonTypes_CellClick);
            // 
            // personTypeBindingSource
            // 
            this.personTypeBindingSource.DataSource = typeof(WikiAPI.Models.PersonType);
            // 
            // petIdDataGridViewTextBoxColumn
            // 
            this.petIdDataGridViewTextBoxColumn.DataPropertyName = "petId";
            this.petIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.petIdDataGridViewTextBoxColumn.Name = "petIdDataGridViewTextBoxColumn";
            // 
            // petDescriptionDataGridViewTextBoxColumn
            // 
            this.petDescriptionDataGridViewTextBoxColumn.DataPropertyName = "petDescription";
            this.petDescriptionDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.petDescriptionDataGridViewTextBoxColumn.Name = "petDescriptionDataGridViewTextBoxColumn";
            // 
            // FrmPersonType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 842);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgPersonTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPersonType";
            this.Text = "FrmPersonType";
            this.Load += new System.EventHandler(this.FrmPersonType_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.DataGridView dtgPersonTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn petIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personTypeBindingSource;
    }
}