using CSharpPosProject.TipoElemento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPosProject.documento_4_3
{
    public class TiqueteElectronico
    {
        public ClaveType Clave { get; set; }//longitud 50
        public string CodigoActividad { get; set; }//longitud 6
        public NumeroConsecutivoType NumeroConsecutivo { get; set; }
        public DateTime FechaEmision { get; set; }
        public EmisorType Emisor { get; set; }
        public ReceptorType Receptor { get; set; }
        public string CondicionVenta { get; set; }
        public string PlazoCredito { get; set; }
        public string MedioPago { get; set; }
        public DetalleServicioType DetalleServicio{ get; set;}
        public OtrosCargosType OtrosCargos { get; set; }
        public ResumenFacturaType ResumenFactura { get; set; }
        public InformacionReferenciaType InformacionReferencia { get; set; }
        public OtrosType Otros {  get; set; }
        public string OtroTexto { get; set; }
        public string OtroContenido { get; set; }




    }
}
