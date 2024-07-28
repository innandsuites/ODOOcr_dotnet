using CSharpPosProject.TipoElemento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharpPosProject.EntidadActividad
{
    
    public class Cabys
    {
        
        public string Codigo { get; set; }
        
        public string Descripcion { get; set; }
        
        public string Impuesto { get; set; }
        

    }
    //[XmlRoot("ProductoServicio")]
    public class ProductoServicio
    {
        //[XmlArray("Cabys")]
        public Cabys[] items { get; set; }
        //public List<Cabys> cabys { get; set; }
    }
    
}
