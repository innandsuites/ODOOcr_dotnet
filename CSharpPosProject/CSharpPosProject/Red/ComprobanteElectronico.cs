using CSharpPosProject.Entidad;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace CSharpPosProject.Red
{
    class ComprobanteElectronico
    {
        String comprobante_url_hwr = "https://api.comprobanteselectronicos.go.cr/recepcion/v1/comprobantes";

        String recepcion_url = "https://api.comprobanteselectronicos.go.cr/recepcion/v1/recepcion";

        public string getProof(Oauth o, int offset, int limit, string cedula, Double expiry)
        {
            string url = "https://api.comprobanteselectronicos.go.cr/recepcion/v1/comprobantes?offset=" + offset + "&limit=" + limit + "&emisor=" + cedula;
            string html = string.Empty;
            
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.PreAuthenticate = true;
                request.Accept = "application/json";
                if (expiry > 5) request.Headers.Add("Authorization", "Bearer " + o.Token);
                else request.Headers.Add("Authorization", "Bearer " + o.Token);
                
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
        public string getProofRestSharp(Oauth o, int offset, int limit, string cedula, Double expiry)
        {
            String url = "https://api.comprobanteselectronicos.go.cr/recepcion/v1/comprobantes";

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest("", Method.Get);

            if (expiry > 5) request.AddHeader("Authorization", "Bearer " + o.Token);
            else request.AddHeader("Authorization", "Bearer " + o.Token);
            request.AddHeader("User-Agent", "Mozilla / 5.0");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("Accept-Encoding", "gzip, deflate, br");

            request.AddParameter("offset", offset, ParameterType.QueryString);
            request.AddParameter("limit", limit, ParameterType.QueryString);
            request.AddParameter("emisor", cedula, ParameterType.QueryString);
            var fullUrl = client.BuildUri(request);

            var response = client.Execute<string>(request);
            return response.Content;
        }
        public string getProofWebClient(Oauth o, int offset, int limit, string cedula, Double expiry)
        {
            string url = "https://api.comprobanteselectronicos.go.cr/recepcion/v1/comprobantes";
            string result;
            WebClient webClient = new WebClient();

            if (expiry > 5) { webClient.Headers.Add("Authorization", "Bearer " + o.Token); }
            else { webClient.Headers.Add("Authorization", "Bearer " + o.Token); }
            webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:126.0) Gecko/20100101 Firefox/126.0");
            webClient.QueryString.Add("offset", offset.ToString());
            webClient.QueryString.Add("limit", limit.ToString());
            webClient.QueryString.Add("emisor", cedula.ToString());
            try { result = webClient.DownloadString(url); }
            catch (Exception ex) { result = ex.Message; }

            return result;
        }
        
    }
}
