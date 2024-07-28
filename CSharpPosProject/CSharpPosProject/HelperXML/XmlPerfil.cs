using CSharpPosProject.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSharpPosProject.HelperXML
{
    public class XmlPerfil
    {
        public string saveData(Persona persona) {
            string filename = "perfil";
            string mensaje = "Error";
            
            
            using (XmlWriter writer = XmlWriter.Create(filename))
            {
                writer.WriteStartElement("Perfil");
                //writer.WriteAttributeString("id", c.Ambiente);
                writer.WriteElementString("Nombre", persona.nombre);
                writer.WriteElementString("Id", persona.numeroIdentificacion);
                writer.WriteEndElement();
                writer.Flush();
                mensaje = "Guardado!";
            }
            return mensaje;
            
        }
    
    }
}
