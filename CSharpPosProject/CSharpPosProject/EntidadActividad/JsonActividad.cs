using CSharpPosProject.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPosProject.EntidadActividad
{
    public class JsonActividad
    {
        public string nombre { get; set; }
        public string tipoIdentificacion { get; set; }
        public Regimen regimen { get; set; }
        public Situacion situacion { get; set; }
        public List<Actividad> actividades { get; set; }

    }
}
