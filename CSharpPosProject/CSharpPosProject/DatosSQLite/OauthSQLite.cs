using CSharpPosProject.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpPosProject.Datos
{
    public class OauthSQLite 
    {
        public void setIdp()
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source = C:\\Users\\daniel\\GitHub\\ODOOcr_dotnet\\CSharpPosProject\\hacienda.db"))
            {
                using(SQLiteCommand cmd = new SQLiteCommand())
                {
                    string strsql = "INSERT INTO idp (id, token, refresh) VALUES (1, 'jdksl', 'uiwowo')";
                    cmd.CommandText = strsql;
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();


                }
            }
        }
        public void updateIdp(Oauth oa)
        {

            using (SQLiteConnection conn = new SQLiteConnection("data source = C:\\Users\\daniel\\GitHub\\Facturador-Desktop\\dotNet\\CSharpPosProject\\hacienda.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    string strsql = "UPDATE idp set id='" +oa.Id+ "' , token='" +oa.Token+ "' , refresh='" +oa.Refresh+ "' , expires_str='" + oa.Expiresstr + "' , expires= current_timestamp where id ='" + oa.Id+ "'";
                    
                    cmd.CommandText = strsql;
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();


                }

            }
        }
        public Oauth selectAll(string id)
        {
            Oauth oauth = new Oauth();
            using (SQLiteConnection conn = new SQLiteConnection("data source = C:\\Users\\daniel\\GitHub\\Facturador-Desktop\\dotNet\\CSharpPosProject\\hacienda.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    string strsql = "Select * from idp where id ='" + id + "' ";
                   
                    cmd.CommandText = strsql;
                    cmd.Connection = conn;
                    conn.Open();

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        
                        oauth.Id = reader["id"].ToString();
                        oauth.Token = reader["token"].ToString();
                        oauth.Refresh = reader["refresh"].ToString();
                        oauth.Expiresstr = reader["expires_str"].ToString();
                        oauth.Expires = (DateTime)reader["expires"];
                    }
                    conn.Close();


                }
            }

            return oauth;
        }
        public Oauth selectAllDecode(string id)
        {
            Oauth oauth = new Oauth();
            using (SQLiteConnection conn = new SQLiteConnection("data source = C:\\Users\\daniel\\GitHub\\Facturador-Desktop\\dotNet\\CSharpPosProject\\hacienda.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    string strsql = "Select * from idp where id ='" + id + "' ";

                    cmd.CommandText = strsql;
                    cmd.Connection = conn;
                    conn.Open();

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        
                        oauth.Id = reader["id"].ToString();
                        oauth.Token = Base64Handler.Base64Decode(reader["token"].ToString());
                        oauth.Refresh = Base64Handler.Base64Decode(reader["refresh"].ToString());
                        oauth.Expiresstr = reader["expires_str"].ToString();
                        oauth.Expires = (DateTime)reader["expires"];
                    }
                    conn.Close();


                }
            }

            return oauth;
        }
    }
}
