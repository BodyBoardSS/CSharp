using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WikiAPI.Models;

namespace WikiFormsApp
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        public FrmHome(User user)
        {
            
            InitializeComponent();
            lblUsuario.Text = user.useUsuario;
            lblUsuario.ForeColor = Color.White;

        }
    }
}
