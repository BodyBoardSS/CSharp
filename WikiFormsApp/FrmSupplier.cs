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
            btnUpdate.Enabled = true;
        }

        private void cleanAll()
        {
            txtType.Clear();
            btnUpdate.Enabled = false;
        }
    }
}
