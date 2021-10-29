using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using WikiAPI.Models;

namespace WikiFormsApp
{
    public partial class FrmRol : Form
    {
        private List<Rol> lstRol = new List<Rol>();
        private Rol rolOject = new Rol();
        public FrmRol()
        {
            InitializeComponent();
        }

        private void fillData() {
            using (var client = new HttpClient())
            {

                var response = client.GetAsync("https://localhost:44348/api/v1/Rol").Result;
                var a = response.Content.ReadAsStringAsync();
                lstRol = JsonConvert.DeserializeObject<List<Rol>>(a.Result.ToString());
                dtgRoles.DataSource = lstRol;
            }
        }

        private void FrmRol_Load(object sender, EventArgs e)
        {
            fillData();
        }

        private void dlgRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rolOject.rolId = Convert.ToInt32(dtgRoles.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtRol.Text = dtgRoles.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnUpdate.Enabled = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            rolOject =  new Rol();
            if (!"".Equals(rolOject.rolNombre)) {
                rolOject.rolNombre = txtRol.Text;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44348/");

                    var response = client.PostAsync("api/v1/Rol", new StringContent(
                                    new JavaScriptSerializer().Serialize(rolOject), Encoding.UTF8, "application/json")).Result;
                    var a = response.Content.ReadAsStringAsync();

                    MessageBox.Show("El rol fue creado!");
                    fillData();
                    cleanAll();
                }
            }
            else
                MessageBox.Show("Debe ingresar un rol!"); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!"".Equals(rolOject.rolNombre))
            {
                rolOject.rolNombre = txtRol.Text;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44348/");

                    var response = client.PutAsync("api/v1/Rol", new StringContent(
                                    new JavaScriptSerializer().Serialize(rolOject), Encoding.UTF8, "application/json")).Result;

                    MessageBox.Show("El rol fue actualizado!");
                    fillData();
                    cleanAll();
                }
            }
            else
                MessageBox.Show("Debe seleccionar un rol!");
        }

        private void cleanAll() {
            txtRol.Clear();
            btnUpdate.Enabled = false;
        }
    }
}
