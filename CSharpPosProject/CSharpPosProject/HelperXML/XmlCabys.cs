using CSharpPosProject.Entidad;
using CSharpPosProject.EntidadActividad;
using NPOI.SS.Formula.Functions;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using static NPOI.HSSF.Util.HSSFColor;

namespace CSharpPosProject.HelperXML
{
    public class XmlCabys
    {
       
        public string saveData(Cabys cabys)
        {
            string filename = "mis_cabys.xml";
            string mensaje = "Error";
            ProductoServicio producto = new ProductoServicio();
            List<Cabys> list = new List<Cabys>();
            XmlCabys xmlCabys = new XmlCabys();
            producto = xmlCabys.readData();
            if (producto == null) { list.Add(cabys); }
            else
            {
                for (int i = 0; i < producto.items.Length + 1; i++)
                {
                    if (producto.items.Length == i)
                    {
                        list.Add(cabys);
                    }
                    else { list.Add(producto.items[i]); }

                }
            }
            producto = new ProductoServicio();
            foreach(Cabys cab in list)
            {
                producto.items = list.ToArray();
            }
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ProductoServicio));

                using (var writer = new StringWriter())
                {
                    serializer.Serialize(writer, producto);
                    mensaje = writer.ToString();
                    //File.Open(filename,FileMode.Open);
                    File.WriteAllText(filename, mensaje, Encoding.Unicode);
                }
            }
        catch(Exception ex) { 
                string msg = ex.Message; }
            return mensaje;

        }
        public string saveData(ProductoServicio producto)
        {
            string filename = "mis_cabys.xml";
            string mensaje = "Error";
            
            List<Cabys> list = new List<Cabys>();
            XmlCabys xmlCabys = new XmlCabys();
            //producto = xmlCabys.readData();
            
                        
                for (int i = 0; i < producto.items.Length; i++)
                {
                   list.Add(producto.items[i]); 

                }
            
           
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ProductoServicio));

                using (var writer = new StringWriter())
                {
                    serializer.Serialize(writer, producto);
                    mensaje = writer.ToString();
                    //File.Open(filename,FileMode.Open);
                    File.WriteAllText(filename, mensaje, Encoding.Unicode);
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return mensaje;

        }
        public string saveDataLegacy(Cabys cabys)
        {
            string filename = "mis_cabys.xml";
            string mensaje = "Error";
            List<Cabys> lista = new List<Cabys> ();
            ProductoServicio productoServicio = new ProductoServicio ();
            //lista = readDataLegacy();
            productoServicio = readDataLegacy();
            lista.Add(cabys);
            
 

            using (XmlWriter writer = XmlWriter.Create(filename))
            {
                writer.WriteStartElement("ProductoServicio");
                foreach (Cabys cab in lista)
                {
                    writer.WriteStartElement("Cabys");
                    //writer.WriteAttributeString("id", c.Ambiente);
                    writer.WriteElementString("Codigo", cab.Codigo);
                    writer.WriteElementString("Descripcion", cab.Descripcion);
                    writer.WriteElementString("Impuesto", cab.Impuesto);
                    writer.WriteEndElement();                   
                  
                }
                writer.WriteEndElement();
                writer.Flush();
            }
            return mensaje;

        }
        public ProductoServicio readData()
        {
            var serializer = new XmlSerializer(typeof(ProductoServicio));

            string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string file = "mis_cabys.xml";
            string result = "";
            Cabys cabys = new Cabys ();
            Cabys[] cabysArr = null;
            ProductoServicio items = new ProductoServicio();
            //cabysArr = (Cabys[])serializer.Deserialize(new XmlTextReader(file));
            try
            {

                //items = (ProductoServicio)serializer.Deserialize(new XmlTextReader(file));
                Stream stream = File.OpenRead(file);
                items = (ProductoServicio)serializer.Deserialize(stream);
                stream.Close();
            }
            catch (Exception ex) { string msg = ex.Message; items = null; }
            //result = cabys.Descripcion + cabys.Codigo + cabys.Impuesto;
            //detalle.cabys = cabysArr;
            return items;
        }
        public ProductoServicio readDataLegacy()
        {
            //string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string file = "mis_cabys.xml";
            int longitud = 0;
            Cabys cabys;
            //List<Cabys> cabysList = new List<Cabys> ();
            ProductoServicio productoServicio = new ProductoServicio();
            Cabys[] cabysArr;
            XmlDocument doc = new XmlDocument();
            int contador = 0;
            string name = "";
            try
            {
                doc.Load(file);
                //XmlNodeList EmpNodes = doc.SelectNodes("//items");
                XmlNode xmlnode = doc.DocumentElement.SelectSingleNode("//items");
                longitud = xmlnode.ChildNodes.Count;
                cabysArr = new Cabys[longitud];
                foreach (XmlNode node in xmlnode)
                {
                    cabys = new Cabys();

                    cabys.Codigo = node.ChildNodes[0].InnerText;
                    cabys.Descripcion = node.ChildNodes[1].InnerText;
                    cabys.Impuesto = node.ChildNodes[2].InnerText;
                    
                    cabysArr[contador++] = cabys;
                   
                }
                productoServicio.items = cabysArr;



            }

            catch (Exception ex) { string msg = ex.Message; }
           
                            return productoServicio;
        }
        public string GetXMLAsString(XmlDocument myxml)
        {

            StringWriter sw = new StringWriter();
            XmlTextWriter tx = new XmlTextWriter(sw);
            myxml.WriteTo(tx);

            string str = sw.ToString();// 
            return str;
        }
    }
}
