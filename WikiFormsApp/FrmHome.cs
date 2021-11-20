using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WikiFormsApp
{
    public partial class FrmHome : Form
    {
        public string idTrabajador = "";
        public string apellidos = "";
        public string nombre = "";
        public string acceso = "";
        public FrmHome()
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
            gestionarPermisos();
            lblUser.Text = nombre+" "+apellidos;
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
            //abrirFormulariosEnWrapper(new FrmRol());
            //seguirdBtn(btnRol);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnWrapper(new FrmTrabajador());
            seguirdBtn(btnTrabajador);
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

        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnWrapper(new FrmVenta());
            seguirdBtn(btnVentas);
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            //abrirFormulariosEnWrapper(new FrmProduct());
            //seguirdBtn(btnAcercaDe);
        }

        private void gestionarPermisos()
        {
            if (acceso == "Administrador")
            {
                btnInfo.Visible = false;
            }
        }

        private void btnTrabajador_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnWrapper(new FrmTrabajador());
            seguirdBtn(btnTrabajador);
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnWrapper(new FrmArticulo());
            seguirdBtn(btnArticulo);
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnWrapper(new FrmCategoria());
            seguirdBtn(btnCategoria);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnWrapper(new FrmCliente());
            seguirdBtn(btnCliente);
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnWrapper(new FrmProveedor());
            seguirdBtn(btnProveedor);
        }

        private void btnPresentacion_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnWrapper(new FrmPresentacion());
            seguirdBtn(btnPresentacion);
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            abrirFormulariosEnWrapper(new FrmIngreso());
            seguirdBtn(btnIngreso);
        }
    }
}
