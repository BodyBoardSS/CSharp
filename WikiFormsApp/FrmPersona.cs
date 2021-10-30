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
    public partial class FrmPersona : Form
    {
        private List<Person> ls = new List<Person>();
        private List<PersonType> lsPersonType = new List<PersonType>();
        private List<City> lsCity = new List<City>();
        private Person obj = new Person();
        DataGridViewComboBoxColumn dgvCmbCity = new  DataGridViewComboBoxColumn();
        public FrmPersona()
        {
            InitializeComponent();
        }

        private void fillData()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync("https://localhost:44348/api/v1/Person").Result;
                var a = response.Content.ReadAsStringAsync();
                ls = JsonConvert.DeserializeObject<List<Person>>(a.Result.ToString());
                dtgPersons.DataSource = ls;

                response = client.GetAsync("https://localhost:44348/api/v1/PersonType").Result;
                a = response.Content.ReadAsStringAsync();
                lsPersonType = JsonConvert.DeserializeObject<List<PersonType>>(a.Result.ToString());
                cmbPersontype.DataSource = lsPersonType;
                cmbPersontype.DisplayMember = "petDescription";
                cmbPersontype.ValueMember = "petId";

                response = client.GetAsync("https://localhost:44348/api/v1/City").Result;
                a = response.Content.ReadAsStringAsync();
                lsCity = JsonConvert.DeserializeObject<List<City>>(a.Result.ToString());
                cmbVity.DataSource = lsCity;
                cmbVity.DisplayMember = "ctyName";
                cmbVity.ValueMember = "ctyId"; 
            }
        }

        private void FrmPerson_Load(object sender, EventArgs e)
        {
            fillData();
        }

        private void dtgPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obj.perId = Convert.ToInt32(dtgPersons.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = dtgPersons.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dtgPersons.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbPersontype.SelectedValue = Convert.ToInt32(dtgPersons.Rows[e.RowIndex].Cells[3].Value.ToString());
            cmbVity.SelectedValue = Convert.ToInt32(dtgPersons.Rows[e.RowIndex].Cells[4].Value.ToString());
            btnUpdate.Enabled = true;
            btnInsert.Enabled = false;
        }

        private void cleanAll()
        {
            txtName.Clear();
            txtLastName.Clear();
            btnUpdate.Enabled = false;
            btnInsert.Enabled = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            obj = new Person();
            if (!"".Equals(txtName.Text) && !"".Equals(txtLastName.Text))
            {
                obj.perName = txtName.Text;
                obj.perLastname = txtLastName.Text;
                obj.perPetId = Convert.ToInt32(cmbPersontype.SelectedValue);
                obj.perCtyId = Convert.ToInt32(cmbVity.SelectedValue);

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44348/");

                    var response = client.PostAsync("api/v1/Person", new StringContent(
                                    new JavaScriptSerializer().Serialize(obj), Encoding.UTF8, "application/json")).Result;

                    MessageBox.Show("El registro fue creado.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    fillData();
                    cleanAll();
                }
            }
            else
                MessageBox.Show("Faltan datos requeridos!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!"".Equals(txtName.Text) && !"".Equals(txtLastName.Text))
            {
                obj.perName = txtName.Text;
                obj.perLastname = txtLastName.Text;
                obj.perPetId = Convert.ToInt32(cmbPersontype.SelectedValue);
                obj.perCtyId = Convert.ToInt32(cmbVity.SelectedValue);

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44348/");

                    var response = client.PutAsync("api/v1/Person/" + obj.perId, new StringContent(
                                    new JavaScriptSerializer().Serialize(obj), Encoding.UTF8, "application/json")).Result;

                    MessageBox.Show("El registro fue actualizado.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    fillData();
                    cleanAll();
                }
            }
            else
                MessageBox.Show("Debe seleccionar una persona!");
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanAll();
        }
    }
}
