using OOP_Lab1.Phones;

namespace OOP_Lab1;

using System.Text.Json;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

public class PhoneJsonSerializer : ISerializer
{
    private static JsonSerializerOptions GetOptions()
    {
        return new JsonSerializerOptions
        {
            WriteIndented = true,
            TypeInfoResolver = new DefaultJsonTypeInfoResolver
            {
                Modifiers = { ResolverModifier }
            }
        };
    }

    // информация о всех наследниках Phone
    private static void ResolverModifier(JsonTypeInfo typeInfo)
    {
        if (typeInfo.Type == typeof(Phone))
        {
            typeInfo.PolymorphismOptions = new JsonPolymorphismOptions
            {
                TypeDiscriminatorPropertyName = "$type", // это будет записано в JSON
                DerivedTypes =
                {
                    new JsonDerivedType(typeof(IPhone), "IPhone"),
                    new JsonDerivedType(typeof(Huawei), "Huawei"),
                    new JsonDerivedType(typeof(GooglePixel), "GooglePixel"),
                    new JsonDerivedType(typeof(Samsung), "Samsung")
                }
            };
        }
    }

    public void Serialize(List<Phone> phones, string filePath)
    {
        string json = JsonSerializer.Serialize(phones, GetOptions());
        File.WriteAllText(filePath, json);
    }

    public List<Phone> Deserialize(string filePath)
    {
        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<Phone>>(json, GetOptions());
    }
}