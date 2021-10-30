using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using WikiAPI.Models;
using WikiFormsApp.Models;

namespace WikiFormsApp
{
    public partial class FrmProduct : Form
    {
        private List<Product> lsProduct = new List<Product>();
        private List<Supplier> lsSup = new List<Supplier>();
        private List<ProductType> lsProductType = new List<ProductType>();
        private Product obj = new Product();
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void fillData()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync("https://localhost:44348/api/v1/Product").Result;
                var a = response.Content.ReadAsStringAsync();
                lsProduct = JsonConvert.DeserializeObject<List<Product>>(a.Result.ToString());
                dtgProducts.DataSource = lsProduct;

                 response = client.GetAsync("https://localhost:44348/api/v1/Supplier").Result;
                 a = response.Content.ReadAsStringAsync();
                lsSup = JsonConvert.DeserializeObject<List<Supplier>>(a.Result.ToString());

                 response = client.GetAsync("https://localhost:44348/api/v1/ProductType").Result;
                 a = response.Content.ReadAsStringAsync();
                lsProductType = JsonConvert.DeserializeObject<List<ProductType>>(a.Result.ToString());
            }
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            fillData();
        }

        private void dtgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obj.prdId = Convert.ToInt32(dtgProducts.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtDescription.Text = dtgProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrice.Text = dtgProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCost.Text = dtgProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtStock.Text = dtgProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtpEntryDate.Value = DateTime.ParseExact(dtgProducts.Rows[e.RowIndex].Cells[5].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            cmbProcutType.SelectedValue = Convert.ToInt32(dtgProducts.Rows[e.RowIndex].Cells[6].Value.ToString());
            cmbSupplier.SelectedValue = Convert.ToInt32(dtgProducts.Rows[e.RowIndex].Cells[7].Value.ToString());
            btnUpdate.Enabled = true;
            btnInsert.Enabled = false;
        }

        private void cleanAll()
        {
            txtDescription.Clear();
            txtCost.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            btnUpdate.Enabled = false;
            btnInsert.Enabled = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            obj = new Product();
            if (!"".Equals(obj.prdDescription))
            {
                obj.prdDescription = txtDescription.Text;
                obj.prdPrice = Convert.ToDouble(txtPrice.Text);
                obj.prdCost = Convert.ToDouble(txtCost.Text);
                obj.prdStock = Convert.ToDouble(txtStock.Text);
                obj.prdEntryDate = dtpEntryDate.Value;
                obj.prdPdtId = Convert.ToInt32(cmbProcutType.SelectedValue);
                obj.prdSupId = Convert.ToInt32(cmbSupplier.SelectedValue);
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44348/");

                    var response = client.PostAsync("api/v1/Product", new StringContent(
                                    new JavaScriptSerializer().Serialize(obj), Encoding.UTF8, "application/json")).Result;

                    MessageBox.Show("El registro fue creado.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    fillData();
                    cleanAll();
                }
            }
            else
                MessageBox.Show("Debe ingresar un Producto!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cleanAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!"".Equals(obj.prdDescription))
            {
                obj.prdDescription = txtDescription.Text;
                obj.prdPrice = Convert.ToDouble(txtPrice.Text);
                obj.prdCost = Convert.ToDouble(txtCost.Text);
                obj.prdStock = Convert.ToDouble(txtStock.Text);
                obj.prdEntryDate = dtpEntryDate.Value;
                obj.prdPdtId = Convert.ToInt32(cmbProcutType.SelectedValue);
                obj.prdSupId = Convert.ToInt32(cmbSupplier.SelectedValue);

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44348/");

                    var response = client.PutAsync("api/v1/Product/" + obj.prdId, new StringContent(
                                    new JavaScriptSerializer().Serialize(obj), Encoding.UTF8, "application/json")).Result;

                    MessageBox.Show("El registro fue actualizado.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    fillData();
                    cleanAll();
                }
            }
            else
                MessageBox.Show("Debe seleccionar un producto!");
        }
    }
}
