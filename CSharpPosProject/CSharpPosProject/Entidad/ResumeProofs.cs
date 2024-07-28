using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPosProject.Entidad
{
    class ResumeProofs
    {
        public string clave {  get; set; }
        public string fecha { get; set; }
        public Persona emisor {  get; set; }
        public Persona receptor { get; set; }
        public string notaCredito { get; set; }
        public string notaDebito { get; set; }

        //public string Clave { get => clave; set => clave = value; }
        //public string Fecha { get => fecha; set => fecha = value; }
        //public string NotaCredito { get => notaCredito; set => notaCredito = value; }
        //public string NotaDebito { get => notaDebito; set => notaDebito = value; }
        //public string Emisor { get => emisor; set => emisor = value; }
        //public string Receptor { get => receptor; set => receptor = value; }


        //internal Persona Emisor { get => Emisor1; set => Emisor1 = value; }
        //internal Persona Receptor { get => Receptor1; set => Receptor1 = value; }
    }
}
