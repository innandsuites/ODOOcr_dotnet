using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Net.Http;
using RestSharp;
using System.Windows.Shapes;
using System.Text.Encodings.Web;
using CSharpPosProject.Entidad;
using System.IO;
using System.Net;
using System.Text;
using System;
using CSharpPosProject.Handler;

namespace CSharpPosProject.Red
{
    class OAUTHmhRequest
    {
        Credencial cred;
        TokenHandler tokenHandler;
        Oauth oauth;
        
        

        public string postRestSharp(Credencial cred)
        {

            var client = new RestClient(cred.Oauth);

            var request = new RestRequest();
            request.AddParameter("client_id", cred.Clientid);
            request.AddParameter("grant_type", "password");
            request.AddParameter("username", cred.Usuario);
            request.AddParameter("password", cred.Clave);
            request.AddHeader("ContentType", "application/x-www-form-urlencoded;charset=utf-8");
            //request.AddFile("file", path);
            var response = client.Post(request);
            var content = response.Content; // Raw content as string

            return response.Content.ToString();
        }

        public string postHttpWebRequest(Credencial cred)
        {
            string html = string.Empty;
            //if(cred.Ambiente == "Pruebas") ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            string data = "client_id=" + cred.Clientid + "&grant_type=password" + "&username=" + cred.Usuario + "&password=" + cred.Clave;
            byte[] dataStream = Encoding.UTF8.GetBytes(data);
            string url = cred.Oauth;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded;charset=utf-8";
                request.Accept = "application/json";

                request.ContentLength = dataStream.Length;
                Stream newStream = request.GetRequestStream();
                newStream.Write(dataStream, 0, dataStream.Length);
                newStream.Close();
                WebResponse webResponse = request.GetResponse();
                using (Stream stream = webResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    String responseString = reader.ReadToEnd();
                    html = responseString;
                }

            }

            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }

            return html;
        }

    }
}
