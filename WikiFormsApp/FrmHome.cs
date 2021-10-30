using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WikiAPI.Models;

namespace WikiFormsApp
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        public FrmHome(User user)
        {
            
            InitializeComponent();

        }

        public void PantallaOk() {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            PantallaOk();
        }

        private void pctSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir del sistema?", "Aviso", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
                Application.Exit();

            //hide and call form login
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnWrapper(new FrmRol());
            seguirdBtn(btnRol);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnWrapper(new FrmSupplier());
            seguirdBtn(btnProveedores);
        }

        private Form formActivado = null;

        private void abrirFormulariosEnWrapper(Form frmHijo) 
        {
            if (formActivado != null)
                formActivado.Close();

            formActivado = frmHijo;
            frmHijo.TopLevel = false;
            frmHijo.Dock = DockStyle.Fill;
            pnlWrapper.Controls.Add(frmHijo);
            pnlWrapper.Tag = frmHijo;
            frmHijo.BringToFront();
            frmHijo.Show();
        }

        private void seguirdBtn(Button sender) {
            pcbRoles.Top = sender.Top;
            pcbRoles.BringToFront();
            pcbRoles.Location = sender.Location;
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnWrapper(new FrmCity());
            seguirdBtn(btnCity);
        }

        private void btnDocumentType_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnWrapper(new FrmDocumentType());
            seguirdBtn(btnDocumentType);
        }

        private void btnProductType_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnWrapper(new FrmProductType());
            seguirdBtn(btnProductType);
        }

        private void btnPersonType_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnWrapper(new FrmPersonType());
            seguirdBtn(btnPersonType);
        }

        private void btnMethodPayment_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnWrapper(new FrmMethodPayment());
            seguirdBtn(btnMethodPayment);
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnWrapper(new FrmPersona());
            seguirdBtn(btnPerson);
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnWrapper(new FrmProduct());
            seguirdBtn(btnProducto);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnWrapper(new FrmProduct());
            seguirdBtn(btnUser);
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnWrapper(new FrmProduct());
            seguirdBtn(btnFacturar);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnWrapper(new FrmProduct());
            seguirdBtn(btnVentas);
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnWrapper(new FrmProduct());
            seguirdBtn(btnAcercaDe);
        }
    }
}
