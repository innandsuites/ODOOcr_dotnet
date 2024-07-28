using CSharpPosProject.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpPosProject.Formularios
{
    public partial class BaseDatosFrm : Form
    {
        public BaseDatosFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OauthSQLite con = new OauthSQLite();
            con.setIdp();
        }
    }
}
