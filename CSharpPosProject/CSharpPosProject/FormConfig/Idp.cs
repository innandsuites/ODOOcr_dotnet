using CSharpPosProject.Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml;

namespace CSharpPosProject.Formularios
{
    public partial class Idp : Form
    {
        int selectedIndex = 0;
        Credencial cred;
        XMLCredencial xmlc;
        string mensaje = "";

        public Idp()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = comboBox1.SelectedIndex;
            string ambiente = "";
            xmlc = new XMLCredencial();
            cred = new Credencial();
            if (selectedIndex == 0) ambiente = "produccion";
            else if(selectedIndex == 1) ambiente = "pruebas";
            cred = xmlc.Lectura(ambiente);
            textBox1.Text = cred.Usuario;
            textBox2.Text = cred.Clave;
            textBox3.Text = cred.Api;
            textBox4.Text = cred.Oauth;
            textBox5.Text = cred.Clientid;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cred = new Credencial();
            if (comboBox1.SelectedIndex == 0) cred.Ambiente = "produccion";
            else if (comboBox1.SelectedIndex == 1) cred.Ambiente = "pruebas";
            xmlc = new XMLCredencial();
            cred.Usuario = textBox1.Text;
            cred.Clave = textBox2.Text;
            cred.Api = textBox3.Text;
            cred.Oauth = textBox4.Text;
            cred.Clientid = textBox5.Text;
            mensaje = xmlc.Escritura(cred);
            MessageBox.Show(mensaje);
        }


    }

     
    
}
