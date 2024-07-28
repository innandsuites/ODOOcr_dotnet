using CSharpPosProject.Entidad;
using CSharpPosProject.EntidadActividad;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPosProject.DatosSQLite
{
    public class ActividadEconSQLite
    {
        string dbpath = "data source = C:\\Users\\daniel\\GitHub\\ODOOcr_dotnet\\CSharpPosProject\\hacienda.db";
        List<Actividad> lista;
        public List<Actividad> selectAll()
        {
            Actividad actividad;
            lista = new List<Actividad>();
            using (SQLiteConnection conn = new SQLiteConnection(dbpath))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    string strsql = "Select * from actividad_econ";

                    cmd.CommandText = strsql;
                    cmd.Connection = conn;
                    conn.Open();

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        actividad = new Actividad();
                        actividad.codigo = reader["id"].ToString();
                        actividad.descripcion = reader["name"].ToString();
                        actividad.estado = reader["estado"].ToString();
                        actividad.tipo = reader["tipo"].ToString();
                        lista.Add(actividad);
                    }
                    conn.Close();


                }
            }

            return lista;
        }
        public Actividad selectAllId(string id)
        {
            Actividad actividad = new Actividad();
            using (SQLiteConnection conn = new SQLiteConnection(dbpath))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    string strsql = "Select * from actividad_econ where id ='" + id + "' ";

                    cmd.CommandText = strsql;
                    cmd.Connection = conn;
                    conn.Open();

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        actividad.codigo = reader["id"].ToString();
                        actividad.descripcion = reader["name"].ToString();
                        actividad.estado = reader["estado"].ToString();
                        actividad.tipo = reader["tipo"].ToString();
                        
                    }
                    conn.Close();


                }
            }

            return actividad;
        }
        public void setActividad(Actividad actividad)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbpath))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    string strsql = "INSERT INTO actividad_econ (id, name, tipo, estado) VALUES ('"
                        +actividad.codigo+ "','" +actividad.descripcion+ "','" +actividad.tipo+ 
                        "','" +actividad.estado+ "')";
                    cmd.CommandText = strsql;
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();


                }
            }
        }
        public void updateActividad(Actividad a)
        {

            using (SQLiteConnection conn = new SQLiteConnection(dbpath))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    string strsql = "UPDATE actividad_econ set id='" + a.codigo + "' , name='"
                        + a.descripcion + "' , tipo='" + a.tipo + "' , estado='"
                        + a.estado + "' where id ='" +a.codigo+ "'";


                    cmd.CommandText = strsql;
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();


                }

            }
        }
    }
}
