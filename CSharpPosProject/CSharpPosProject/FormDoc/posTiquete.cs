using CSharpPosProject.DatosSQLite;
using CSharpPosProject.EntidadActividad;
using CSharpPosProject.Handler;
using CSharpPosProject.HelperXML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpPosProject.FormDoc
{
    public partial class posTiquete : Form
    {
        int suma_total = 0;
        int registry_count = 0;
        ActividadEconSQLite actividadEconSQLite;
        Actividad actividad;
        List<Actividad> listaActividad;
        ProductoServicio producto = new ProductoServicio();
        XmlCabys xmlcabys;
        string[] tokens;


        int count;
        public posTiquete()
        {
            InitializeComponent();
            lbFecha.Text = DateTime.Now.ToString();
            populateComboActividad();populateComboServicio();
           
        }

        private void populateComboActividad()
        {
            actividadEconSQLite = new ActividadEconSQLite();
            actividad = new Actividad();
            listaActividad = new List<Actividad>();
            listaActividad = actividadEconSQLite.selectAll();
            int i = 0;
            foreach (Actividad ac in listaActividad)
            {                
                comboBox1.Items.Add(ac.tipo + " " + ac.codigo + " " + ac.descripcion);
                if (ac.tipo == "P") comboBox1.SelectedIndex = i;
                i++;
            }

        }
        private void populateComboServicio()
        {
            xmlcabys = new XmlCabys();
            producto = xmlcabys.readData();
            foreach (Cabys c in producto.items)
            {
                string txt = c.Codigo.ToString() +"-" + c.Descripcion;
                comboBox2.Items.Add(txt);
                comboBox2.SelectedIndex = 0;
                textBoxCod.Text = c.Codigo.ToString();
            }

        }

        private void buttonAgr_Click(object sender, EventArgs e)
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

        private void buttonEli_Click(object sender, EventArgs e)
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

        private void posTiquete_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(label3, "Base Imponible");
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
           // Clipboard.SetText(textBox2.Text);
           string clipboard = Clipboard.GetText();
           tokens = clipboard.Split('\n');
            string txtcadena ="";
            for (int i = 0; i < tokens.Length; i++)
            {

                txtcadena += tokens[i] + " - ";
            }
            textBox2.Text = txtcadena;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string txt = comboBox2.Text;
            string[] token = comboBox2.Text.ToString().Split(new char[] { '-' });
            textBoxCod.Text = token[0];

        }
    }
}
