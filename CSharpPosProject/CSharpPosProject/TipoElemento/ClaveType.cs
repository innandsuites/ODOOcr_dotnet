using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPosProject.TipoElemento
{
    public class ClaveType
    {
        public string codigo_pais { get; set; }//1-3 longitud 3
        public string dia {  get; set; }//4-5 longitud 2
        public string mes {  get; set; }//6-7 longitud 2
        public string anyo {  get; set; }//8-9 longitud 2
        public string cedula_emisor {  get; set; }//10-21 longitud 12
        NumeroConsecutivoType consecutivo {  get; set; }//22-41 longitud 20
        string situacion_doc {  get; set; }//42 longitud 1
        string seguridad { get; set; }//43-50 longitud 8


    }
}
