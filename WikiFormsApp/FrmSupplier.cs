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
    public partial class FrmSupplier : Form
    {
        private List<Supplier> ls = new List<Supplier>();
        private List<Person> lsPerson = new List<Person>();
        private Supplier obj = new Supplier();

        public FrmSupplier()
        {
            InitializeComponent();
        }

        private void fillData()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync("https://localhost:44348/api/v1/Supplier").Result;
                var a = response.Content.ReadAsStringAsync();
                ls = JsonConvert.DeserializeObject<List<Supplier>>(a.Result.ToString());
                dtgDocumentTypes.DataSource = ls;

                response = client.GetAsync("https://localhost:44348/api/v1/Person").Result;
                a = response.Content.ReadAsStringAsync();
                lsPerson = JsonConvert.DeserializeObject<List<Person>>(a.Result.ToString());
                cmbPersona.DataSource = lsPerson;
                cmbPersona.DisplayMember = "perName";
                cmbPersona.ValueMember = "perId";
            }
        }

        private void FrmSuppliere_Load(object sender, EventArgs e)
        {
            fillData();
        }

        private void dtgSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obj.supId = Convert.ToInt32(dtgDocumentTypes.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtType.Text = dtgDocumentTypes.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbPersona.SelectedValue = Convert.ToInt32(dtgDocumentTypes.Rows[e.RowIndex].Cells[2].Value.ToString());
            btnUpdate.Enabled = true;
            btnInsert.Enabled = false;
        }

        private void cleanAll()
        {
            txtType.Clear();
            btnUpdate.Enabled = false;
            btnInsert.Enabled = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            obj = new Supplier();
            if (!"".Equals(txtType.Text))
            {
                obj.supTradename = txtType.Text;
                obj.supPerId = Convert.ToInt32(cmbPersona.SelectedValue);

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44348/");

                    var response = client.PostAsync("api/v1/Supplier", new StringContent(
                                    new JavaScriptSerializer().Serialize(obj), Encoding.UTF8, "application/json")).Result;

                    MessageBox.Show("El registro fue creado.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    fillData();
                    cleanAll();
                }
            }
            else
                MessageBox.Show("Debe ingresar una descripcion!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!"".Equals(txtType.Text))
            {
                obj.supTradename = txtType.Text;
                obj.supPerId = Convert.ToInt32(cmbPersona.SelectedValue);

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44348/");

                    var response = client.PutAsync("api/v1/Supplier/" + obj.supId, new StringContent(
                                    new JavaScriptSerializer().Serialize(obj), Encoding.UTF8, "application/json")).Result;

                    MessageBox.Show("El registro fue actualizado.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    fillData();
                    cleanAll();
                }
            }
            else
                MessageBox.Show("Debe seleccionar un proveedor!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cleanAll();
        }
    }
}
