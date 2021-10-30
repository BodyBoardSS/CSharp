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
    public partial class FrmDocumentType : Form
    {
        private List<DocumentType> lsPTypes = new List<DocumentType>();
        private DocumentType obj = new DocumentType();

        public FrmDocumentType()
        {
            InitializeComponent();
        }

        private void fillData()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync("https://localhost:44348/api/v1/DocumentType").Result;
                var a = response.Content.ReadAsStringAsync();
                lsPTypes = JsonConvert.DeserializeObject<List<DocumentType>>(a.Result.ToString());
                dtgDocumentTypes.DataSource = lsPTypes;
            }
        }

        private void FrmDocumentType_Load(object sender, EventArgs e)
        {
            fillData();
        }

        private void dtgDocumentTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obj.dctId = Convert.ToInt32(dtgDocumentTypes.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtType.Text = dtgDocumentTypes.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnUpdate.Enabled = true;
        }

        private void cleanAll()
        {
            txtType.Clear();
            btnUpdate.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            obj = new DocumentType();
            if (!"".Equals(obj.dctDescription))
            {
                obj.dctDescription = txtType.Text;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44348/");

                    var response = client.PostAsync("api/v1/DocumentType", new StringContent(
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
            if (!"".Equals(obj.dctDescription))
            {
                obj.dctDescription = txtType.Text;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44348/");

                    var response = client.PutAsync("api/v1/DocumentType/" + obj.dctId, new StringContent(
                                    new JavaScriptSerializer().Serialize(obj), Encoding.UTF8, "application/json")).Result;

                    MessageBox.Show("El registro fue actualizado.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    fillData();
                    cleanAll();
                }
            }
            else
                MessageBox.Show("Debe seleccionar un tipo de documento!");
        }
    }
}
