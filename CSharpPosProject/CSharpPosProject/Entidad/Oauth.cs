using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPosProject.Entidad
{
    public class Oauth
    {
        private string id;
        private string token;
        private DateTime expires;
        private string expiresstr;
        private string refresh;
        


        public string Refresh { get => refresh; set => refresh = value; }      
        public string Token { get => token; set => token = value; }
        public string Id { get => id; set => id = value; }        
        public DateTime Expires { get => expires; set => expires = value; }
        public string Expiresstr { get => expiresstr; set => expiresstr = value; }
    }
}
