using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPosProject.TipoElemento
{
    public class ResumenFacturaType
    {
        public CodigoTipoMonedaType CodigoMoneda { get; set; } //minOccurs="0"
        public string TotalServGravados { get; set; }
        public string TotalServExentos { get; set; }
        public string TotalServExonerado { get; set; }
        public string TotalMercanciasGravadas { get; set; }
        public string TotalMercanciasExentas { get; set; }
        public string TotalMercExonerada { get; set; }
        public string TotalGravado { get; set; }
        public string TotalExento { get; set; }
        public string TotalExonerado { get; set; }
        public string TotalVenta { get; set; }
        public string TotalDescuentos{ get; set; }
        public string TotalVentaNeta{ get; set; }
        public string TotalImpuesto { get; set; }
        public string TotalIVADevuelto { get; set; }
        public string TotalOtrosCargos { get; set; }
        public string TotalComprobante { get; set; }







    }
}
