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
    public partial class FrmProductType : Form
    {
        private List<ProductType> lsPTypes = new List<ProductType>();
        private ProductType obj = new ProductType();

        public FrmProductType()
        {
            InitializeComponent();
        }

        private void fillData()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync("https://localhost:44348/api/v1/ProductType").Result;
                var a = response.Content.ReadAsStringAsync();
                lsPTypes = JsonConvert.DeserializeObject<List<ProductType>>(a.Result.ToString());
                dtgProductTypes.DataSource = lsPTypes;
            }
        }

        private void FrmProductType_Load(object sender, EventArgs e)
        {
            fillData();
        }

        private void dtgProductTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obj.pdtId = Convert.ToInt32(dtgProductTypes.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtType.Text = dtgProductTypes.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnUpdate.Enabled = true;
        }

        private void cleanAll()
        {
            txtType.Clear();
            btnUpdate.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            obj = new ProductType();
            if (!"".Equals(obj.pdtDescription))
            {
                obj.pdtDescription = txtType.Text;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44348/");

                    var response = client.PostAsync("api/v1/ProductType", new StringContent(
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
            if (!"".Equals(obj.pdtDescription))
            {
                obj.pdtDescription = txtType.Text;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44348/");

                    var response = client.PutAsync("api/v1/ProductType/" + obj.pdtId, new StringContent(
                                    new JavaScriptSerializer().Serialize(obj), Encoding.UTF8, "application/json")).Result;

                    MessageBox.Show("El registro fue actualizado.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    fillData();
                    cleanAll();
                }
            }
            else
                MessageBox.Show("Debe seleccionar un tipo de producto!");
        }
    }
}
