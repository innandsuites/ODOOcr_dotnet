using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Net;
using System.IO;

namespace CSharpPosProject.Red
{
    internal class ActividadEconomica
    {
        public string postRestChart(string cedula)
        {
            string respuesta = "error";
            
            try
            {

                //var client = new RestClient("https://api.hacienda.go.cr/fe/ae?identificacion=701850132");
                var client = new RestClient("https://api.hacienda.go.cr/fe");
                //var request = new RestRequest();
                var request = new RestRequest($"/ae?identificacion={cedula}", Method.Get);
                var response = client.Execute(request);
                respuesta = response.Content.ToString();

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

            return respuesta;
            
        }
        public string postHttpWebRequest(string cedula)
        {
            
            string html = string.Empty;
            string url = "https://api.hacienda.go.cr/fe/ae?identificacion="+cedula;
            try
            {
                //System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    String responseString = reader.ReadToEnd();
                    html = responseString;
                }
            }

            catch (Exception ex)
            {
                html = ex.Message;
            }

            return html;
        }
    }
}
