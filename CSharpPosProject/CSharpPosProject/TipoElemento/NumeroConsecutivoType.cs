using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPosProject.TipoElemento
{
    public class NumeroConsecutivoType
    {
        string sucursal {  get; set; }//0-3 longitud 3 espacios
        string caja {  get; set; }//4-8 longitud 5
        string tipo_comprobante {  get; set; }//9-10 longitud 2
        string consecutivo {  get; set; }//11-20 longitud 10

    }
}
