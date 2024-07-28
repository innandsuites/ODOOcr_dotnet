using CSharpPosProject.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace CSharpPosProject
{
    class XMLCredencial
    {
        Credencial cred;
        Credencial urlcode;

        public XMLCredencial()
        {
            cred = new Credencial();
        }
        public Credencial Lectura(string ambiente)
        {
            XmlDocument doc = new XmlDocument();
            cred = new Credencial();
            try
            {
                if (ambiente == "produccion") doc.Load("prod.xml");
                else doc.Load("sandbox.xml");
                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    String id = node.Attributes["id"].Value;
                    //Console.WriteLine("id: " + id);
                    if (node.HasChildNodes)
                    {
                        for (int i = 0; i < node.ChildNodes.Count; i++)
                        {
                            //cred.Ambiente = "Produccion";
                            cred.Ambiente = id;
                            if (i == 0)
                            {
                                cred.Usuario = Base64Handler.Base64Decode(node.ChildNodes[i].InnerText);

                            }
                            if (i == 1)
                            {
                                cred.Clave = Base64Handler.Base64Decode(node.ChildNodes[i].InnerText);

                            }
                            if (i == 2)
                            {
                                cred.Api = Base64Handler.Base64Decode(node.ChildNodes[i].InnerText);
                            }
                            if (i == 3)
                            {
                                cred.Oauth = Base64Handler.Base64Decode(node.ChildNodes[i].InnerText);
                            }
                            if (i == 4)
                            {
                                cred.Clientid = Base64Handler.Base64Decode(node.ChildNodes[i].InnerText);
                            }


                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("primero guarde las credenciales" +ex); }

            return cred;
        }
        public Credencial LecturaUrlCode(string ambiente)
        {
            XmlDocument doc = new XmlDocument();
            cred = new Credencial();
            urlcode = new Credencial();
            try
            {
                if (ambiente == "produccion") doc.Load("prod.xml");
                else doc.Load("sandbox.xml");
                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    String id = node.Attributes["id"].Value;
                    //Console.WriteLine("id: " + id);
                    if (node.HasChildNodes)
                    {
                        for (int i = 0; i < node.ChildNodes.Count; i++)
                        {
                            //cred.Ambiente = "Produccion";
                            cred.Ambiente = id;
                            if (i == 0)
                            {
                                cred.Usuario = Base64Handler.Base64Decode(node.ChildNodes[i].InnerText);
                                urlcode.Usuario = System.Web.HttpUtility.UrlEncode(cred.Usuario);
                            }
                            if (i == 1)
                            {
                                cred.Clave = Base64Handler.Base64Decode(node.ChildNodes[i].InnerText);
                                urlcode.Clave = System.Web.HttpUtility.UrlEncode(cred.Clave);
                            }
                            if (i == 2)
                            {
                                cred.Api = Base64Handler.Base64Decode(node.ChildNodes[i].InnerText);
                                urlcode.Api = cred.Api;
                            }
                            if (i == 3)
                            {
                                cred.Oauth = Base64Handler.Base64Decode(node.ChildNodes[i].InnerText);
                                urlcode.Oauth = cred.Oauth;
                            }
                            if (i == 4)
                            {
                                cred.Clientid = Base64Handler.Base64Decode(node.ChildNodes[i].InnerText);
                                urlcode.Clientid = System.Web.HttpUtility.UrlEncode(cred.Clientid);
                            }


                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("primero guarde las credenciales" + ex); }

            return urlcode;
        }
        public string Escritura(Credencial c) 
        {
            string filename = "";
            string mensaje = "Error al guardar cambios";
            string cadena64 = "";
            if (c.Ambiente == "produccion") filename = "prod.xml";
            else filename = "sandbox.xml";
            using (XmlWriter writer = XmlWriter.Create(filename))
            {
                writer.WriteStartElement("Credencial");
                writer.WriteStartElement("Ambiente");
                writer.WriteAttributeString("id", c.Ambiente);
                cadena64 = Base64Handler.Base64Encode(c.Usuario);
                writer.WriteElementString("Usuario", cadena64);
                cadena64 = Base64Handler.Base64Encode(c.Clave);
                writer.WriteElementString("Clave", cadena64);
                cadena64 = Base64Handler.Base64Encode(c.Api);
                writer.WriteElementString("Api", cadena64);
                cadena64 = Base64Handler.Base64Encode(c.Oauth);
                writer.WriteElementString("Oauth", cadena64);
                cadena64 = Base64Handler.Base64Encode(c.Clientid);
                writer.WriteElementString("Clientid", cadena64);
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.Flush();
                mensaje = "Guardado!";
            }
            return mensaje;
        }
    }
}
