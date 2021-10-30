﻿
namespace WikiFormsApp
{
    partial class FrmMethodPayment
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
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.dtgMethodPayments = new System.Windows.Forms.DataGridView();
            this.methodPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtpIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtpDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMethodPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodPaymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.txtMethod);
            this.groupBox1.Location = new System.Drawing.Point(49, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 181);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metodo de pago";
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
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metodo:";
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
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(77, 43);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(210, 20);
            this.txtMethod.TabIndex = 0;
            // 
            // dtgMethodPayments
            // 
            this.dtgMethodPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMethodPayments.AutoGenerateColumns = false;
            this.dtgMethodPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMethodPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mtpIdDataGridViewTextBoxColumn,
            this.mtpDescriptionDataGridViewTextBoxColumn});
            this.dtgMethodPayments.DataSource = this.methodPaymentBindingSource;
            this.dtgMethodPayments.Location = new System.Drawing.Point(49, 346);
            this.dtgMethodPayments.Name = "dtgMethodPayments";
            this.dtgMethodPayments.Size = new System.Drawing.Size(1221, 373);
            this.dtgMethodPayments.TabIndex = 12;
            this.dtgMethodPayments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMethodPayment_CellClick);
            // 
            // methodPaymentBindingSource
            // 
            this.methodPaymentBindingSource.DataSource = typeof(WikiAPI.Models.MethodPayment);
            // 
            // mtpIdDataGridViewTextBoxColumn
            // 
            this.mtpIdDataGridViewTextBoxColumn.DataPropertyName = "mtpId";
            this.mtpIdDataGridViewTextBoxColumn.HeaderText = "Pd";
            this.mtpIdDataGridViewTextBoxColumn.Name = "mtpIdDataGridViewTextBoxColumn";
            // 
            // mtpDescriptionDataGridViewTextBoxColumn
            // 
            this.mtpDescriptionDataGridViewTextBoxColumn.DataPropertyName = "mtpDescription";
            this.mtpDescriptionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.mtpDescriptionDataGridViewTextBoxColumn.Name = "mtpDescriptionDataGridViewTextBoxColumn";
            // 
            // FrmMethodPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 842);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgMethodPayments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMethodPayment";
            this.Text = "FrmMethodPayment";
            this.Load += new System.EventHandler(this.FrmMethodPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMethodPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodPaymentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        public System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.DataGridView dtgMethodPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtpIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtpDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource methodPaymentBindingSource;
    }
}