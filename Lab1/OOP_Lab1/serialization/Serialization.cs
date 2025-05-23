//using Autopark.CarTypes;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using System.Xml.Serialization;
using Newtonsoft.Json;
using OOP_Lab1;
using OOP_Lab1.Phones;
using OOP_Lab1.Types;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace serialization
{
    public class PhoneConverter : System.Text.Json.Serialization.JsonConverter<Phone>
    {
        public override Phone Read(ref Utf8JsonReader reader, System.Type typeToConvert, JsonSerializerOptions options)
        {
            using JsonDocument doc = JsonDocument.ParseValue(ref reader);
            var jsonObject = doc.RootElement;

            var type = jsonObject.GetProperty("@xsi:type").GetString();
            System.Type[] allTypes = Types.GetTypes();
            if (type != null)
            {
                var phoneType = allTypes.FirstOrDefault(t => t.Name == type);
                var rawJson = jsonObject.GetRawText();

                var optionsWithConverter = new JsonSerializerOptions
                {
                    Converters =
                    {
                        //new JustConverter<string>() 
                    }
                };

                if (System.Text.Json.JsonSerializer.Deserialize(rawJson, phoneType!, options) is Phone phone)
                {
                    return phone;
                }
            }

            throw new Exception("Deserialization error");
        }

        public override void Write(Utf8JsonWriter writer, Phone value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            var phoneType = value.GetType();

            writer.WriteString("@xsi:type", value.GetType().Name);
            foreach (var property in phoneType.GetProperties())
            {
                var stringValue = property.GetValue(value) as string; // Приведение к string
                if (stringValue != null)
                {
                    writer.WriteString(property.Name, stringValue); // Запись свойства как строку
                }
   
            }

            writer.WriteEndObject();
        }
    }

    /* public class JustConverter<T> : System.Text.Json.Serialization.JsonConverter<T>
    {
        public override T Read(ref Utf8JsonReader reader, System.Type typeToConvert, JsonSerializerOptions options)
        {
            return JsonSerializer.Deserialize<T>(ref reader)!;
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, options);
        }
    }*/
    public static class Serialization
    {
        public delegate void ExtraSerialize(List<Phone> phones, FileStream fileStream);
        public delegate void ExtraDeserialize(List<Phone> phones, FileStream fileStream);

        public static ExtraSerialize? extraSerialize = null;
        public static ExtraDeserialize? extraDeserialize = null;

        public static JsonSerializerOptions options;
        public static XmlSerializer formatter;

        static Serialization()
        {
            options = new JsonSerializerOptions
            {
                WriteIndented = true,
                  Converters = { new PhoneConverter() }
            };

            System.Type[] allTypes = Types.GetTypes();
            var baseClassType = typeof(Phone);
            List<System.Type> types = new List<System.Type>();
            foreach (var type in allTypes)
            {
                if (!type.IsAbstract && baseClassType.IsAssignableFrom(type))
                {
                    types.Add(type);
                }
            }
            //formatter = new XmlSerializer(typeof(List<Phone>), types.ToArray());
        }

        public static void Serialize(string fileName)
        {

            using var fileStream = File.Create(fileName);
            if (fileName.EndsWith(".json"))
            {
                if (extraSerialize == null)
                {
                    System.Text.Json.JsonSerializer.Serialize(fileStream, Program.phonesList, options);
                }
                else
                {
                    extraSerialize(Program.phonesList, fileStream);
                }
            }
            /*else
            {
                formatter.Serialize(fileStream, Program.phonesList);
            }*/
        }

        public static void Deserialize(string fileName)
        {
            using var fileStream = File.Open(fileName, FileMode.Open);
            if (fileName.EndsWith(".json"))
            {
                if (System.Text.Json.JsonSerializer.Deserialize(fileStream, typeof(List<Phone>), options) is List<Phone> list)
                {
                    Program.phonesList = list;
                    //Program.Cars!.UpdateView();
                    //Program.Cars!.UpdateHistory();
                }
            }
            /*else
            {
                if (extraSerialize == null)
                {
                    if (formatter.Deserialize(fileStream) is List<Phone> list)
                    {
                        Program.phonesList = list;
                        //Program.Cars!.UpdateView();
                        //Program.Cars!.UpdateHistory();
                    }
                }
                else
                {
                    extraDeserialize!(Program.phonesList, fileStream);                   
                }
            }*/
        }
    }
}