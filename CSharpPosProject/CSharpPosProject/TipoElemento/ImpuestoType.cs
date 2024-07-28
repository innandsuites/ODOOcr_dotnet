using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPosProject.TipoElemento
{
    public class ImpuestoType
    {
        public string Codigo { get; set; }
        public string CodigoTarifa { get; set; }
        public string Tarifa { get; set; }
        public string FactorIVA { get; set; }
        public string Monto { get; set; }
        public ExoneracionType Exoneracion { get; set; }
        
    }
}
