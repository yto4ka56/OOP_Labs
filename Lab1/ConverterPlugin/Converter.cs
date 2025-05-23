
using OOP_Lab1;
using Newtonsoft.Json;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using OOP_Lab1.Phones;
using serialization;

namespace Converter
{
    public class Converter : ISerializer
    {
        public static void Serialize(List<Phone> phones, FileStream fileStream)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(phones, Serialization.options);

            fileStream.Write(Encoding.UTF8.GetBytes(json));

            json = "{" +
                    "\"@xmlns:xsi\": \"http://www.w3.org/2001/XMLSchema-instance\", \"@xmlns:xsd\": \"http://www.w3.org/2001/XMLSchema\", " +
                    "\"Car\": " +
                    json +
                    "}";
            XNode node = JsonConvert.DeserializeXNode(json, "ArrayOfPhone")!;

            using var fileStreamXml = File.Create(fileStream.Name.Replace(".json", ".xml"));
            fileStreamXml.Write(Encoding.UTF8.GetBytes("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n" + node.ToString()));
        }

        public static void Deserialize(List<Phone> phones, FileStream fileStream)
        {
            using MemoryStream memoryStream = new MemoryStream();

            fileStream.CopyTo(memoryStream);
            byte[] fileBytes = memoryStream.ToArray();

            string xml = Encoding.UTF8.GetString(fileBytes);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            string json = JsonConvert.SerializeXmlNode(doc);
            if (json.Contains('['))
            {
                json = json[json.IndexOf('[')..(json.LastIndexOf(']') + 1)];
            }
            else
            {
                json = "[" + json[(json.IndexOf("\"Phone\"") + 6)..(json.LastIndexOf('}') - 1)] + "]";
            }

            if (System.Text.Json.JsonSerializer.Deserialize(json, typeof(List<Phone>), Serialization.options) is List<Phone> list)
            {
                phones = list;
                //cars.UpdateView();
                //cars.UpdateHistory();
            }
        }
    }
}