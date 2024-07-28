using CSharpPosProject.Datos;
using CSharpPosProject.Entidad;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpPosProject.Red;


namespace CSharpPosProject.Handler
{
    class TokenHandlerPG
    {
        Oauth oauth;
        //OauthPostgreSQL oauthPostgreSQL;
        DateTime dateNow;
        DateTime dateStored;
        TimeSpan timespan;
        Double respuesta;
        OAUTHmhRequest oAUTHmhRequest = new OAUTHmhRequest();
        string str_oauth;
        XMLCredencial xMLCredencia = new XMLCredencial();
        Credencial credencial = new Credencial();
        OauthSQLite oauthSQLite;
        
        
        public Double verifyExpiry(string id)
        { // obtiene minutos transcurridos del utltimo token y actualiza el mismo
            oauth= new Oauth();
            OauthSQLite oauthSQLite = new OauthSQLite();
            oauth = oauthSQLite.selectAllDecode(id);
            dateStored = DateTime.Parse(oauth.Expiresstr);
            dateNow = DateTime.Now;
            timespan = dateNow - dateStored;
            credencial = xMLCredencia.Lectura(id);
            
            if(timespan.TotalMinutes > 20) { 
                str_oauth = oAUTHmhRequest.postHttpWebRequest(credencial);
                oauth = getOauthObject(str_oauth, id);
                oauth = oauthSQLite.selectAll(id);
                dateStored = DateTime.Parse(oauth.Expiresstr);
                dateNow = DateTime.Now;
                timespan = dateNow - dateStored;

            }
            return timespan.TotalMinutes;
        }
        public Oauth getOauthObject(string jsonstring, string id)
        {// convierte un string a objeto oauth y actualiza en base datos
            //en base64 ademas lo devuelve decodificado
            oauth = new Oauth();
            oauthSQLite = new OauthSQLite();
            var jsonObject = JsonConvert.DeserializeObject(jsonstring);
            JObject json = JObject.Parse(jsonObject.ToString());
            var token = json["access_token"];
            var refresh = json["refresh_token"];
            oauth.Id = id;
            oauth.Token = Base64Handler.Base64Encode(token.ToString());
            oauth.Refresh = Base64Handler.Base64Encode(refresh.ToString());
            
            //oauth.Expiresstr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            oauth.Expiresstr = DateTime.Now.ToString();
            oauthSQLite.updateIdp(oauth);

            //oauth = oauthSQLite.selectAllDecode(id);
            return oauth;
        }
        public Oauth getOauthObjectDecode(string id)
        {
            oauthSQLite = new OauthSQLite();
            oauth = new Oauth();
            oauth = oauthSQLite.selectAllDecode(id);
            return oauth;
        }
    }
}

