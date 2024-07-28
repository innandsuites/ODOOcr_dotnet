using CSharpPosProject.odoo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpPosProject
{
    public partial class OdooConfigFrm : Form
    {
        Test2 test;
        List<string> result;
        int longitud;
        string cadena;
        public OdooConfigFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test = new Test2();
            result = new List<string>();
            result = test.callPy();
            longitud = result.Count;
            for(int i = 0; i < longitud; i++)
            {
                cadena += result[i];
            }
            textBox1.Text = cadena;
        }
    }
}
