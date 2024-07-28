using CSharpPosProject.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPosProject.DatosSQLite
{
    public class PersonaSQLite
    {
        string dbpath = "data source = C:\\Users\\daniel\\GitHub\\ODOOcr_dotnet\\CSharpPosProject\\hacienda.db";
        public void setPersona(Persona p)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbpath))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    string strsql = "INSERT INTO persona (id, name, tipo, telefono, email, domicilio) " +
                        "VALUES ('" +p.numeroIdentificacion+ "', '" +p.nombre+ "', '" 
                        +p.tipoIdentificacion+ "', '" +p.telefono+ "', '" +p.email+
                        "', '" +p.domicilio+ "')";
                    cmd.CommandText = strsql;
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();


                }
            }
        }
       
        public Persona selectAll(string id)
        {
            Persona persona = new Persona();
            using (SQLiteConnection conn = new SQLiteConnection(dbpath))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    string strsql = "Select * from personas where id ='" + id + "' ";

                    cmd.CommandText = strsql;
                    cmd.Connection = conn;
                    conn.Open();

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        persona.numeroIdentificacion = reader["id"].ToString();
                        persona.nombre = reader["name"].ToString();
                        persona.tipoIdentificacion = reader["tipo"].ToString();
                        persona.telefono = reader["telefono"].ToString();
                        persona.email = reader["email"].ToString();
                        persona.domicilio = reader["domicilio"].ToString();
                    }
                    conn.Close();


                }
            }

            return persona;
        }
        
    }
}
