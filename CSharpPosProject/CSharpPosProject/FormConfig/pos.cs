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
    public partial class pos : Form
    {
        int suma_total = 0;
        int registry_count = 0;
        public pos()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            registry_count = (dataGridViewPos.Rows.Count) - 1;
            if (registry_count == -1) registry_count = 0;
            string[] datos = new string[4];
            datos[0] = textBoxCod.Text;
            datos[1] = "Objeto";
            datos[2] = textBoxCan.Text;
            datos[3] = "2000";
            dataGridViewPos.Rows.Add(datos);
            suma_total += Convert.ToInt32(dataGridViewPos.Rows[registry_count].Cells[3].Value);
            //++last_registry;
            textBoxTot.Text = suma_total.ToString();
            textBoxCod.Text = "";
            textBoxCan.Text = "1";
            textBoxCod.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = dataGridViewPos.CurrentRow.Index;
                suma_total -= Convert.ToInt32(dataGridViewPos.Rows[fila].Cells[3].Value);
                dataGridViewPos.Rows.RemoveAt(fila);

                textBoxTot.Text = suma_total.ToString();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("no existen datos en la seleccion");
            }
        }



        private void textBoxCod_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                registry_count = (dataGridViewPos.Rows.Count) - 1;
                if (registry_count == -1) registry_count = 0;
                string[] datos = new string[4];
                datos[0] = textBoxCod.Text;
                datos[1] = "Objeto";
                datos[2] = textBoxCan.Text;
                datos[3] = "2000";
                dataGridViewPos.Rows.Add(datos);
                suma_total += Convert.ToInt32(dataGridViewPos.Rows[registry_count].Cells[3].Value);
                //++last_registry;
                textBoxTot.Text = suma_total.ToString();
                textBoxCod.Text = "";
                textBoxCan.Text = "1";
                textBoxCod.Select();
            }

        }
    }
}
