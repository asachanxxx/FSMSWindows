using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace FSMS.Repository
{

    [Serializable()]
    public class XMLTool
    {
        public string CreateXML(Object ClassObject)
        {
            XmlDocument xmlDoc = new XmlDocument();   //Represents an XML document, 

            // Initializes a new instance of the XmlDocument class.          
            XmlSerializer xmlSerializer = new XmlSerializer(ClassObject.GetType());
            // Creates a stream whose backing store is memory. 
            using (MemoryStream xmlStream = new MemoryStream())
            {
                xmlSerializer.Serialize(xmlStream, ClassObject);
                xmlStream.Position = 0;
                //Loads the XML document from the specified string.
                xmlDoc.Load(xmlStream);
                return xmlDoc.InnerXml;
            }
        }

        public string Serialize(object obj)
        {
            var builder = new StringBuilder();
            var xmlSerializer = new XmlSerializer(obj.GetType());
            using (XmlWriter writer = XmlWriter.Create(builder, new XmlWriterSettings() { OmitXmlDeclaration = true, CloseOutput = true }))
            {

                xmlSerializer.Serialize(writer, obj);

            }
            return builder.ToString();
        }

    }
}

