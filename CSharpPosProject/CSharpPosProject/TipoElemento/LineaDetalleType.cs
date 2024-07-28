using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPosProject.TipoElemento
{
    public class LineaDetalleType
    {
        public string NumeroLinea {  get; set; }
        public string Codigo { get; set; }//longitud 13
        public CodigoType CodigoComercial { get; set; }//longitud 0-5
        public string Cantidad {  get; set; } //xs:totalDigits ="16" xs:fractionDigits ="3" />
        public UnidadMedidaType UnidadMedida { get; set; }
        public string UnidadMedidaComercial { get; set; } //minOccurs="0"
        public string Detalle { get; set; }//minOccurs="0"
        public string PrecioUnitario { get; set; }//DecimalDinero
        public string MontoTotal { get; set; }
        //Se obtiene de multiplicar el campo cantidad por el campo precio unitario
        public DescuentoType Descuento { get; set; }
        public string SubTotal { get; set; }
        //Se obtiene de la resta del campo monto total menos monto de descuento concedido
        public string BaseImponible { get; set; }
        public ImpuestoType Impuesto { get; set; }
        //Cuando el producto o servicio este gravado con algún impuesto se debe indicar cada uno de ellos
        public string ImpuestoNeto { get; set; }
        public string MontoTotalLinea { get; set; }
        //Cuando no existe exoneración, se obtiene de la sumatoria de los campos “subtotal”, “monto del impuesto” .
        //Cuando posee una exoneración, se obtiene de la sumatoria de los campos “Subtotal”, “Impuesto Neto” 



    }
}
