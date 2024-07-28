using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPosProject.Entidad
{
     class Credencial
    {
        private string usuario;
        private string clave;
        private string ambiente;
        private string api;
        private string oauth;
        private string clientid;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Ambiente { get => ambiente; set => ambiente = value; }
        public string Oauth { get => oauth; set => oauth = value; }
        public string Api { get => api; set => api = value; }
        public string Clientid { get => clientid; set => clientid = value; }
    }
}
