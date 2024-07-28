using CSharpPosProject.Datos;
using CSharpPosProject.Entidad;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpPosProject.EntidadActividad;
using CSharpPosProject.DatosSQLite;
using System.Data.Entity.Core.Mapping;

namespace CSharpPosProject.Handler
{

    public class ActividadHandler
    {
        public string cadena = "";
        int count = 0;
        string[] datos;
        Actividad actividad;
        private List<Actividad> listaAct;
        public SortedDictionary<string, string> map;
        ActividadEconSQLite queryActividad;

        public JsonActividad getActividadObject(string jsonstring)
        {// convierte un string a objeto 
            
            int count;
            JsonActividad jsonActividad = new JsonActividad();
            var jsonObject = JsonConvert.DeserializeObject<JsonActividad>(jsonstring);
            jsonActividad = (JsonActividad)jsonObject;

            return jsonActividad;
        }
        public string formatoCadena(JsonActividad jsonActividad)
        {
            count = jsonActividad.actividades.Count;
            actividad = new Actividad();
            for (int i = 0; i < count; i++)
            {
                actividad = jsonActividad.actividades[i];
                cadena += " Codigo: " + actividad.codigo + " Estado: " + actividad.estado +
                    " Tipo: " + actividad.tipo + " Descripcion: " + actividad.descripcion + "\n\n";
            }

            return cadena;
        }
        

    }

}
