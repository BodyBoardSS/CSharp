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
    public partial class FrmPersonType : Form
    {
        private List<PersonType> lsPTypes = new List<PersonType>();
        private PersonType obj = new PersonType();
        public FrmPersonType()
        {
            InitializeComponent();
        }

        private void fillData()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync("https://localhost:44348/api/v1/PersonType").Result;
                var a = response.Content.ReadAsStringAsync();
                lsPTypes = JsonConvert.DeserializeObject<List<PersonType>>(a.Result.ToString());
                dtgPersonTypes.DataSource = lsPTypes;
            }
        }

        private void FrmPersonType_Load(object sender, EventArgs e)
        {
            fillData();
        }

        private void dtgPersonTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obj.petId = Convert.ToInt32(dtgPersonTypes.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtType.Text = dtgPersonTypes.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnUpdate.Enabled = true;
        }

        private void cleanAll()
        {
            txtType.Clear();
            btnUpdate.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            obj = new PersonType();
            if (!"".Equals(obj.petDescription))
            {
                obj.petDescription = txtType.Text;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44348/");

                    var response = client.PostAsync("api/v1/PersonType", new StringContent(
                                    new JavaScriptSerializer().Serialize(obj), Encoding.UTF8, "application/json")).Result;

                    MessageBox.Show("El registro fue creado.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    fillData();
                    cleanAll();
                }
            }
            else
                MessageBox.Show("Debe ingresar un tipo!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!"".Equals(obj.petDescription))
            {
                obj.petDescription = txtType.Text;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44348/");

                    var response = client.PutAsync("api/v1/PersonType/" + obj.petId, new StringContent(
                                    new JavaScriptSerializer().Serialize(obj), Encoding.UTF8, "application/json")).Result;

                    MessageBox.Show("El registro fue actualizado.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    fillData();
                    cleanAll();
                }
            }
            else
                MessageBox.Show("Debe seleccionar un tipo de persona!");
        }
    }
}
