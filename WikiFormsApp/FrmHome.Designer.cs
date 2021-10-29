
namespace WikiFormsApp
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnCity = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnRol = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlWrapper = new System.Windows.Forms.Panel();
            this.pnlHrader = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pctSalir = new System.Windows.Forms.PictureBox();
            this.pcbRoles = new System.Windows.Forms.PictureBox();
            this.btnDocumentType = new System.Windows.Forms.Button();
            this.btnProductType = new System.Windows.Forms.Button();
            this.btnPersonType = new System.Windows.Forms.Button();
            this.btnMethodPayment = new System.Windows.Forms.Button();
            this.btnPerson = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlSideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHrader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.pnlSideBar.Controls.Add(this.btnProducto);
            this.pnlSideBar.Controls.Add(this.btnPerson);
            this.pnlSideBar.Controls.Add(this.btnMethodPayment);
            this.pnlSideBar.Controls.Add(this.btnPersonType);
            this.pnlSideBar.Controls.Add(this.btnProductType);
            this.pnlSideBar.Controls.Add(this.btnDocumentType);
            this.pnlSideBar.Controls.Add(this.pcbRoles);
            this.pnlSideBar.Controls.Add(this.btnCity);
            this.pnlSideBar.Controls.Add(this.btnProveedores);
            this.pnlSideBar.Controls.Add(this.btnRol);
            this.pnlSideBar.Controls.Add(this.panel2);
            this.pnlSideBar.Controls.Add(this.panel1);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.ForeColor = System.Drawing.Color.Gainsboro;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(270, 881);
            this.pnlSideBar.TabIndex = 0;
            // 
            // btnCity
            // 
            this.btnCity.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCity.FlatAppearance.BorderSize = 0;
            this.btnCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCity.ForeColor = System.Drawing.Color.LightGray;
            this.btnCity.Location = new System.Drawing.Point(0, 312);
            this.btnCity.Name = "btnCity";
            this.btnCity.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCity.Size = new System.Drawing.Size(270, 45);
            this.btnCity.TabIndex = 9;
            this.btnCity.Text = "Ciudad";
            this.btnCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCity.UseVisualStyleBackColor = true;
            this.btnCity.Click += new System.EventHandler(this.btnCity_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.ForeColor = System.Drawing.Color.LightGray;
            this.btnProveedores.Location = new System.Drawing.Point(0, 267);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProveedores.Size = new System.Drawing.Size(270, 45);
            this.btnProveedores.TabIndex = 7;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnRol
            // 
            this.btnRol.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRol.FlatAppearance.BorderSize = 0;
            this.btnRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRol.ForeColor = System.Drawing.Color.LightGray;
            this.btnRol.Location = new System.Drawing.Point(0, 222);
            this.btnRol.Name = "btnRol";
            this.btnRol.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRol.Size = new System.Drawing.Size(270, 45);
            this.btnRol.TabIndex = 5;
            this.btnRol.Text = "Roles";
            this.btnRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRol.UseVisualStyleBackColor = true;
            this.btnRol.Click += new System.EventHandler(this.btnRol_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 151);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 71);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.label1.Location = new System.Drawing.Point(121, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "WIKI SV";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlWrapper
            // 
            this.pnlWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.pnlWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWrapper.Location = new System.Drawing.Point(270, 0);
            this.pnlWrapper.Name = "pnlWrapper";
            this.pnlWrapper.Size = new System.Drawing.Size(1334, 881);
            this.pnlWrapper.TabIndex = 1;
            // 
            // pnlHrader
            // 
            this.pnlHrader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.pnlHrader.Controls.Add(this.lblDashboard);
            this.pnlHrader.Controls.Add(this.pctSalir);
            this.pnlHrader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHrader.Location = new System.Drawing.Point(270, 0);
            this.pnlHrader.Name = "pnlHrader";
            this.pnlHrader.Size = new System.Drawing.Size(1334, 60);
            this.pnlHrader.TabIndex = 2;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.lblDashboard.Location = new System.Drawing.Point(15, 23);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(234, 24);
            this.lblDashboard.TabIndex = 1;
            this.lblDashboard.Text = "PANEL DE ADMINISTRACION";
            this.lblDashboard.UseCompatibleTextRendering = true;
            // 
            // pctSalir
            // 
            this.pctSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctSalir.Image = ((System.Drawing.Image)(resources.GetObject("pctSalir.Image")));
            this.pctSalir.Location = new System.Drawing.Point(1287, 12);
            this.pctSalir.Name = "pctSalir";
            this.pctSalir.Size = new System.Drawing.Size(35, 35);
            this.pctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSalir.TabIndex = 0;
            this.pctSalir.TabStop = false;
            this.pctSalir.Click += new System.EventHandler(this.pctSalir_Click);
            // 
            // pcbRoles
            // 
            this.pcbRoles.Image = ((System.Drawing.Image)(resources.GetObject("pcbRoles.Image")));
            this.pcbRoles.Location = new System.Drawing.Point(3, 226);
            this.pcbRoles.Name = "pcbRoles";
            this.pcbRoles.Size = new System.Drawing.Size(35, 35);
            this.pcbRoles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRoles.TabIndex = 6;
            this.pcbRoles.TabStop = false;
            // 
            // btnDocumentType
            // 
            this.btnDocumentType.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocumentType.FlatAppearance.BorderSize = 0;
            this.btnDocumentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentType.ForeColor = System.Drawing.Color.LightGray;
            this.btnDocumentType.Location = new System.Drawing.Point(0, 357);
            this.btnDocumentType.Name = "btnDocumentType";
            this.btnDocumentType.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDocumentType.Size = new System.Drawing.Size(270, 45);
            this.btnDocumentType.TabIndex = 10;
            this.btnDocumentType.Text = "Tipo de documento";
            this.btnDocumentType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocumentType.UseVisualStyleBackColor = true;
            this.btnDocumentType.Click += new System.EventHandler(this.btnDocumentType_Click);
            // 
            // btnProductType
            // 
            this.btnProductType.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductType.FlatAppearance.BorderSize = 0;
            this.btnProductType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductType.ForeColor = System.Drawing.Color.LightGray;
            this.btnProductType.Location = new System.Drawing.Point(0, 402);
            this.btnProductType.Name = "btnProductType";
            this.btnProductType.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProductType.Size = new System.Drawing.Size(270, 45);
            this.btnProductType.TabIndex = 11;
            this.btnProductType.Text = "Tipo de producto";
            this.btnProductType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductType.UseVisualStyleBackColor = true;
            this.btnProductType.Click += new System.EventHandler(this.btnProductType_Click);
            // 
            // btnPersonType
            // 
            this.btnPersonType.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonType.FlatAppearance.BorderSize = 0;
            this.btnPersonType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonType.ForeColor = System.Drawing.Color.LightGray;
            this.btnPersonType.Location = new System.Drawing.Point(0, 447);
            this.btnPersonType.Name = "btnPersonType";
            this.btnPersonType.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPersonType.Size = new System.Drawing.Size(270, 45);
            this.btnPersonType.TabIndex = 12;
            this.btnPersonType.Text = "Tipo de persona";
            this.btnPersonType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonType.UseVisualStyleBackColor = true;
            this.btnPersonType.Click += new System.EventHandler(this.btnPersonType_Click);
            // 
            // btnMethodPayment
            // 
            this.btnMethodPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMethodPayment.FlatAppearance.BorderSize = 0;
            this.btnMethodPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMethodPayment.ForeColor = System.Drawing.Color.LightGray;
            this.btnMethodPayment.Location = new System.Drawing.Point(0, 492);
            this.btnMethodPayment.Name = "btnMethodPayment";
            this.btnMethodPayment.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMethodPayment.Size = new System.Drawing.Size(270, 45);
            this.btnMethodPayment.TabIndex = 13;
            this.btnMethodPayment.Text = "Metodo de pago";
            this.btnMethodPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMethodPayment.UseVisualStyleBackColor = true;
            this.btnMethodPayment.Click += new System.EventHandler(this.btnMethodPayment_Click);
            // 
            // btnPerson
            // 
            this.btnPerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerson.FlatAppearance.BorderSize = 0;
            this.btnPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerson.ForeColor = System.Drawing.Color.LightGray;
            this.btnPerson.Location = new System.Drawing.Point(0, 537);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPerson.Size = new System.Drawing.Size(270, 45);
            this.btnPerson.TabIndex = 14;
            this.btnPerson.Text = "Persona";
            this.btnPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.ForeColor = System.Drawing.Color.LightGray;
            this.btnProducto.Location = new System.Drawing.Point(0, 582);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProducto.Size = new System.Drawing.Size(270, 45);
            this.btnProducto.TabIndex = 15;
            this.btnProducto.Text = "Producto";
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.pnlHrader);
            this.Controls.Add(this.pnlWrapper);
            this.Controls.Add(this.pnlSideBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wiki";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.pnlSideBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHrader.ResumeLayout(false);
            this.pnlHrader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlWrapper;
        private System.Windows.Forms.Panel pnlHrader;
        public System.Windows.Forms.PictureBox pctSalir;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Button btnRol;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnCity;
        public System.Windows.Forms.PictureBox pcbRoles;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnPerson;
        private System.Windows.Forms.Button btnMethodPayment;
        private System.Windows.Forms.Button btnPersonType;
        private System.Windows.Forms.Button btnProductType;
        private System.Windows.Forms.Button btnDocumentType;
    }
}