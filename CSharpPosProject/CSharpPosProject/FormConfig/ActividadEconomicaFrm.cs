using CSharpPosProject.DatosSQLite;
using CSharpPosProject.Entidad;
using CSharpPosProject.EntidadActividad;
using CSharpPosProject.Handler;
using CSharpPosProject.HelperXML;
using CSharpPosProject.Red;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CSharpPosProject.Formularios
{
    public partial class ActividadEconomicaFrm : Form
    {
        ActividadEconomica ae;
        JsonActividad jsonActividad;
        ActividadHandler actividadHandler;
        string[] datos;
        ActividadEconSQLite actividadEconSQLite;
        Actividad actividad;
        Persona persona;
        List<Actividad> actividadList;
        XmlPerfil xmlPerfil = new XmlPerfil();
        public ActividadEconomicaFrm()
        {
            InitializeComponent();
            
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            jsonActividad = new JsonActividad();
            actividadHandler = new ActividadHandler();
            searchOnDB();
        }
        public void searchOnDB()
        {
            actividadList = new List<Actividad>();
            actividadEconSQLite = new ActividadEconSQLite();
            actividadList = actividadEconSQLite.selectAll();
            datos = new string[4];
            if (actividadList.Count > 0)
            {
                for (int i = 0; i < actividadList.Count; i++)
                {
                    actividad = new Actividad();
                    //actividad = actividadList[i];
                    datos[0] = actividadList[i].codigo;
                    datos[1] = actividadList[i].tipo;
                    datos[2] = actividadList[i].estado;
                    datos[3] = actividadList[i].descripcion;
                    dataGridView1.Rows.Add(datos);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 20;
            textBox2.Text = textBox1.Text;
            textBox1.Text = "";
            dataGridView1.Rows.Clear();
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            progressBar1.Value = 40;
            System.Threading.Thread.Sleep(1000);
            progressBar1.Value = 60;
            ae = new ActividadEconomica();
            progressBar1.Value = 80;
            string respuesta = "error";
            if (radioButton2.Checked) respuesta = ae.postRestChart(textBox2.Text);
            if (radioButton1.Checked) respuesta = ae.postHttpWebRequest(textBox2.Text);
            if (respuesta.Contains("40") || respuesta.Contains("50")) MessageBox.Show(respuesta);
            else
            {
                jsonActividad = actividadHandler.getActividadObject(respuesta);
                textBox3.Text = jsonActividad.nombre;
                textBox4.Text = jsonActividad.regimen.codigo;
                textBox5.Text = jsonActividad.regimen.descripcion;
                textBox6.Text = jsonActividad.situacion.moroso;
                textBox7.Text = jsonActividad.situacion.omiso;
                textBox8.Text = jsonActividad.situacion.estado;
                textBox9.Text = jsonActividad.situacion.administracionTributaria;
                progressBar1.Value = 100;
                datos = new string[4];
                for (int i = 0; i < jsonActividad.actividades.Count; i++)
                {
                    datos[0] = jsonActividad.actividades[i].codigo;
                    datos[1] = jsonActividad.actividades[i].tipo;
                    datos[2] = jsonActividad.actividades[i].estado;
                    datos[3] = jsonActividad.actividades[i].descripcion;
                    dataGridView1.Rows.Add(datos);
                }
            }
            progressBar1.Value = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            actividad = new Actividad();
            persona = new Persona();
            actividadEconSQLite = new ActividadEconSQLite();
            if (jsonActividad.actividades != null)
            {
                for (int i = 0; i < jsonActividad.actividades.Count; i++)
                {
                    actividad = actividadEconSQLite.selectAllId(jsonActividad.actividades[i].codigo);
                    if (actividad.codigo == null)
                    {
                        actividadEconSQLite.setActividad(jsonActividad.actividades[i]);
                    }
                    else { actividadEconSQLite.updateActividad(jsonActividad.actividades[i]); }


                }
                persona.nombre = textBox3.Text;
                persona.numeroIdentificacion = textBox2.Text;
                string texto = xmlPerfil.saveData(persona);
                if (texto == "Error") MessageBox.Show("Error al guardar perfil");

                MessageBox.Show("Actividades Actualizadas");
            }

        }
    }
}
