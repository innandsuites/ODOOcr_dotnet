using CSharpPosProject.Datos;
using CSharpPosProject.Entidad;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPosProject.Handler
{
    class JsonResponseHandler
    {

        public ResumeProofs[] getListProofObject(string jsonstring)
        {// convierte un string a objeto oauth y actualiza en base datos

            var result = JsonConvert.DeserializeObject<List<ResumeProofs>>(jsonstring);

            int longitud = result.Count;
            ResumeProofs[] lista = new ResumeProofs[longitud];
            ResumeProofs resume = new ResumeProofs();

            Persona emisor = new Persona();
            Persona receptor = new Persona();
            string prueba;
           for ( int i = 0; i < longitud; i++)
            {
                emisor = result[i].emisor;
                receptor = result[i].receptor;
                //prueba = result[i].Emisor;
                resume.fecha = result[i].fecha;
                resume.emisor = emisor;
                resume.clave = result[i].clave;
                resume.receptor = receptor;
                lista[i] = resume;

            }
            
            return lista;
        }
    }
}
