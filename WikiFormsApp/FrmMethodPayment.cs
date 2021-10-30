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
    public partial class FrmMethodPayment : Form
    {
        private List<MethodPayment> ls = new List<MethodPayment>();
        private MethodPayment obj = new MethodPayment();
        public FrmMethodPayment()
        {
            InitializeComponent();
        }

        private void fillData()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync("https://localhost:44348/api/v1/MethodPayment").Result;
                var a = response.Content.ReadAsStringAsync();
                ls = JsonConvert.DeserializeObject<List<MethodPayment>>(a.Result.ToString());
                dtgMethodPayments.DataSource = ls;
            }
        }

        private void FrmMethodPayment_Load(object sender, EventArgs e)
        {
            fillData();
        }

        private void dtgMethodPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obj.mtpId = Convert.ToInt32(dtgMethodPayments.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtMethod.Text = dtgMethodPayments.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnUpdate.Enabled = true;
        }

        private void cleanAll()
        {
            txtMethod.Clear();
            btnUpdate.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            obj = new MethodPayment();
            if (!"".Equals(obj.mtpDescription))
            {
                obj.mtpDescription = txtMethod.Text;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44348/");

                    var response = client.PostAsync("api/v1/MethodPayment", new StringContent(
                                    new JavaScriptSerializer().Serialize(obj), Encoding.UTF8, "application/json")).Result;

                    MessageBox.Show("El registro fue creado.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    fillData();
                    cleanAll();
                }
            }
            else
                MessageBox.Show("Debe ingresar un metodo!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!"".Equals(obj.mtpDescription))
            {
                obj.mtpDescription = txtMethod.Text;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44348/");

                    var response = client.PutAsync("api/v1/MethodPayment/" + obj.mtpId, new StringContent(
                                    new JavaScriptSerializer().Serialize(obj), Encoding.UTF8, "application/json")).Result;

                    MessageBox.Show("El registro fue actualizado.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    fillData();
                    cleanAll();
                }
            }
            else
                MessageBox.Show("Debe seleccionar un metodo de pago!");
        }
    }
}
