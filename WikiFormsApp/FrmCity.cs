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
    public partial class FrmCity : Form
    {
        private List<City> lsCities = new List<City>();
        private City obj = new City();
        public FrmCity()
        {
            InitializeComponent();
        }

        private void fillData()
        {
            using (var client = new HttpClient())
            {

                var response = client.GetAsync("https://localhost:44348/api/v1/City").Result;
                var a = response.Content.ReadAsStringAsync();
                lsCities = JsonConvert.DeserializeObject<List<City>>(a.Result.ToString());
                dtgCities.DataSource = lsCities;
            }
        }

        private void FrmCity_Load(object sender, EventArgs e)
        {
            fillData();
        }

        private void dlgCities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obj.ctyId = Convert.ToInt32(dtgCities.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = dtgCities.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnUpdate.Enabled = true;
        }

        private void cleanAll()
        {
            txtName.Clear();
            btnUpdate.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            obj = new City();
            if (!"".Equals(obj.ctyName))
            {
                obj.ctyName = txtName.Text;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44348/");

                    var response = client.PostAsync("api/v1/City", new StringContent(
                                    new JavaScriptSerializer().Serialize(obj), Encoding.UTF8, "application/json")).Result;

                    fillData();
                    cleanAll();
                }
            }
            else
                MessageBox.Show("Debe ingresar un nombre de una ciudad!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!"".Equals(obj.ctyName))
            {
                obj.ctyName = txtName.Text;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44348/");

                    var response = client.PutAsync("api/v1/City/"+obj.ctyId, new StringContent(
                                    new JavaScriptSerializer().Serialize(obj), Encoding.UTF8, "application/json")).Result;

                    fillData();
                    cleanAll();
                }
            }
            else
                MessageBox.Show("Debe seleccionar una ciudad!");
        }
    }
}
