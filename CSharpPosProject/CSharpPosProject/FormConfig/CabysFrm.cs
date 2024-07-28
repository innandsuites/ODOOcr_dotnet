
using CSharpPosProject.EntidadActividad;
using CSharpPosProject.HelperXML;
using CSharpPosProject.xls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Math.EC.ECCurve;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Reflection;
using System.Web.UI.WebControls;
using System.Xml;

namespace CSharpPosProject.FormConfig
{
    public partial class CabysFrm : Form
    {
        DataTable sheetData;
        Cabys cabys;
        List<Cabys> cabysList;
        XmlCabys xmlcabys;
        bool click = false;
        public CabysFrm()
        {
            InitializeComponent();
            populateData();
        }
        public void populateData()
        {
            XLSHandler xsl = new XLSHandler();
            sheetData = new DataTable();
            sheetData = xsl.ReadExcel();
            dataGridView1.DataSource = sheetData;
            DataGridViewColumn column1 = dataGridView1.Columns[0]; // Replace 0 with the column index
            column1.Width = 150; // Set the desired width
            DataGridViewColumn column2 = dataGridView1.Columns[1]; // Replace 0 with the column index
            column2.Width = 492; // Set the desired width
            DataGridViewColumn column3 = dataGridView1.Columns[2]; // Replace 0 with the column index
            column3.Width = 70; // Set the desired width

        }

        private void button1_Click(object sender, EventArgs e)
        {
            click = false;
            //dataGridView1.Rows.Clear();
            XLSHandler xsl = new XLSHandler();
            sheetData = new DataTable();
            sheetData = xsl.ReadExcel();
            dataGridView1.DataSource = sheetData;
            DataGridViewColumn column1 = dataGridView1.Columns[0]; // Replace 0 with the column index
            column1.Width = 150; // Set the desired width
            DataGridViewColumn column2 = dataGridView1.Columns[1]; // Replace 0 with the column index
            column2.Width = 492; // Set the desired width
            DataGridViewColumn column3 = dataGridView1.Columns[2]; // Replace 0 with the column index
            column3.Width = 70; // Set the desired width
            //string result = xsl.ReadExcel();
            //xsl.WriteExcel();
            string no = "";
            //metodo LoadWorksheetInDataTable
            //
            //DataTable sheetData = new DataTable();
            //string path = "C:\\Users\\daniel\\GitHub\\Facturador-Desktop\\Cabys-edited.xlsx";
            //sheetData = xsl.LoadWorksheetInDataTable(path, "Cabys");
            //string not = "noth";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            click = false;
            DataRow[] filteredRows = sheetData.Select("Descripcion LIKE '%" +textBox1.Text+ "%'");
            cabys = new Cabys();
            cabysList = new List<Cabys>();
            
            for (int i = 0; i < filteredRows.Length; i++)
            {
                cabys = new Cabys();
                cabys.Codigo = filteredRows[i].ItemArray[0].ToString();
                cabys.Descripcion = filteredRows[i].ItemArray[1].ToString();
                cabys.Impuesto = filteredRows[i].ItemArray[2].ToString();
                cabysList.Add(cabys);
                
            }
            dataGridView1.DataSource = cabysList;
            DataGridViewColumn column1 = dataGridView1.Columns[0]; // Replace 0 with the column index
            column1.Width = 150; // Set the desired width
            DataGridViewColumn column2 = dataGridView1.Columns[1]; // Replace 0 with the column index
            column2.Width = 492; // Set the desired width
            DataGridViewColumn column3 = dataGridView1.Columns[2]; // Replace 0 with the column index
            column3.Width = 70; // Set the desired width

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            textBox2.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            click = false;
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Selecciones una fila de la lista");
            }
            else
            {
                XmlCabys xmlCabys = new XmlCabys();
                Cabys cabys = new Cabys();
                cabys.Codigo = textBox2.Text;
                cabys.Descripcion = textBox3.Text;
                cabys.Impuesto = textBox4.Text;
                ProductoServicio productoServicio = new ProductoServicio();
                //productoServicio = xmlcabys.readData();
                string respuesta = xmlCabys.saveData(cabys);
                
                MessageBox.Show(respuesta);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {//mis codigos cabys
            click = true;
            xmlcabys = new XmlCabys();
            cabysList = new List<Cabys>();
            //cabys = new Cabys();
            //cabys = xmlcabys.readData();
            //List<Cabys> lista = new List<Cabys>();
            //lista = xmlcabys.readDataLegacy();
            //MessageBox.Show(lista.Count.ToString());
            ProductoServicio lista = new ProductoServicio();
            lista = xmlcabys.readDataLegacy();
            cabysList = lista.items.ToList();
            //File.WriteAllText("mis_cabys.xml", lista.ToString(), Encoding.Unicode);
            //MessageBox.Show(lista.items.Length.ToString());
            //dataGridView1.Rows.Clear();
            dataGridView1.DataSource = cabysList;
            DataGridViewColumn column1 = dataGridView1.Columns[0]; // Replace 0 with the column index
            column1.Width = 150; // Set the desired width
            DataGridViewColumn column2 = dataGridView1.Columns[1]; // Replace 0 with the column index
            column2.Width = 495; // Set the desired width
            DataGridViewColumn column3 = dataGridView1.Columns[2]; // Replace 0 with the column index
            column3.Width = 80; // Set the desired width

        }

        private void button4_Click(object sender, EventArgs e)
        {//eliminar item
            if (click)
            {
                
                List<Cabys> nuevalista = new List<Cabys>();
                //nuevalista = cabysList;
                foreach(Cabys cabys in cabysList) {

                    if (cabys.Codigo != textBox2.Text)
                    {
                        nuevalista.Add(cabys);
                        
                    }
                }
                
                ProductoServicio producto = new ProductoServicio();
                producto.items = nuevalista.ToArray();
                xmlcabys = new XmlCabys();
                string result = xmlcabys.saveData(producto);
            }

        }
    }
    
}
