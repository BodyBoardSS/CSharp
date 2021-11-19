using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Threading;
using WikiFormsApp.Controller;

namespace WikiFormsApp
{
    public partial class Login : Form
    {
        Thread th;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtUsuario, "");
            errorProvider1.SetError(txtPass, "");
            if (txtUsuario.Text.ToString().Trim() != "" && txtPass.Text.ToString().Trim() != "")
            {
                    try
                    {
                        DataTable Datos = NTrabajador.Login(this.txtUsuario.Text, this.txtPass.Text);

                        if (Datos.Rows.Count == 0)
                        {
                            lblErrorMessage.Text = "Invalid login credentials.";
                            lblErrorMessage.ForeColor = Color.Red;
                        }
                        else
                        {
                            FrmHome frm = new FrmHome();
                            frm.idTrabajador = Datos.Rows[0][0].ToString();
                            frm.apellidos = Datos.Rows[0][1].ToString();
                            frm.nombre = Datos.Rows[0][2].ToString();
                            frm.acceso = Datos.Rows[0][3].ToString();

                            frm.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception ex) {
                        MessageBox.Show("No fue posible ingresar al sistema, favor llamar al administrador.","¡Alerta!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        Console.WriteLine(ex);
                    }
            }
            else if (txtUsuario.Text.ToString().Trim() == "" && txtPass.Text.ToString().Trim() == "")
            {
                errorProvider1.SetError(txtUsuario, "Please enter the email");
                errorProvider1.SetError(txtPass, "Please enter the password");
            }
            else if (txtUsuario.Text.ToString().Trim() == "")
            {
                errorProvider1.SetError(txtUsuario, "Please enter the email");
            }
            else if (txtPass.Text.ToString().Trim() == "")
            {
                errorProvider1.SetError(txtPass, "Please enter the password");
            }
        }

        private void ValidateEmail()
        {
            Regex regEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                                    + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                    + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
                                    + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                    + @"[a-zA-Z]{2,}))$",
                                    RegexOptions.Compiled);

            if (!regEmail.IsMatch(txtUsuario.Text))
            {
                errorProvider1.SetError(txtUsuario, "Please enter a Valid Email Address.");
            }
            else
            {
                errorProvider1.SetError(txtUsuario, "");
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmail();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsuario.Clear();
            txtPass.Clear();
        }
    }
}
