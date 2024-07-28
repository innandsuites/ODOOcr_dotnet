using CSharpPosProject.Datos;
using CSharpPosProject.Entidad;
using CSharpPosProject.Handler;
using CSharpPosProject.Red;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public partial class BuscarComprobantes : Form
    {
        String url = "https://api.comprobanteselectronicos.go.cr/recepcion/v1/comprobantes";
       
        Oauth oauth = new Oauth();
        
        ComprobanteElectronico comprobanteElectronico = new ComprobanteElectronico();
        string respuesta;
        Double expiry;
        OauthSQLite oauthSQLite = new OauthSQLite();
        string cedula ="";
        
        public BuscarComprobantes()
        {
            InitializeComponent();
            
            label1.Text = url;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XMLCredencial xMLCredencial = new XMLCredencial();
            OAUTHmhRequest oAUTHacienda = new OAUTHmhRequest();
            Credencial credencial = new Credencial();
            TokenHandler tokenHandler = new TokenHandler();
            oauth = oauthSQLite.selectAllDecode("produccion");
            expiry = tokenHandler.verifyExpiry(oauth);
            cedula = textBox1.Text;
            respuesta = comprobanteElectronico.getProofWebClient(oauth, 0, 10, cedula, expiry);
            if (respuesta.Contains("error")) MessageBox.Show(respuesta);
            else
            {
                ResumeProofs[] lista;
                JsonResponseHandler jsonResponseHandler = new JsonResponseHandler();
                lista = jsonResponseHandler.getListProofObject(respuesta);
                ResumeProofs resumeProofs = new ResumeProofs();
                for (int i = 0; i < lista.Length; i++)
                {
                    resumeProofs = lista[i];
                    var item = resumeProofs.clave + "        " + resumeProofs.fecha;
                    listBox1.Items.Add(item);
                }
            }
            


        }
    }
}
