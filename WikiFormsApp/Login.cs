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
using WikiAPI.Models;

namespace WikiFormsApp
{
    public partial class Login : Form
    {
        Thread th;
        User user;
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
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44348/");
                    user = new User { useEmail = txtUsuario.Text.ToString(), usePassword = txtPass.Text.ToString() };
                    
                    var response = client.PostAsync("api/v1/Login", new StringContent(
                                    new JavaScriptSerializer().Serialize(user), Encoding.UTF8, "application/json")).Result;
                    var a = response.Content.ReadAsStringAsync();
                    
                    if (a.Result.ToString().Trim() == "0")
                    {
                        lblErrorMessage.Text = "Invalid login credentials.";
                        lblErrorMessage.ForeColor = Color.Red;
                    }
                    else
                    {
                        var result = JsonConvert.DeserializeObject<User>(a.Result.ToString());
                        Console.WriteLine(a);
                        this.Close();
                        th = new Thread(opennewform);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
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

        public void opennewform(object obj)
        {
            Application.Run(new FrmHome(user));
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

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmail();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
