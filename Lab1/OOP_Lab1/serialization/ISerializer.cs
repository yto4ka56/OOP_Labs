using OOP_Lab1.Phones;

namespace OOP_Lab1;

public interface ISerializer
{
    public static void Serialize(List<Phone> phones, FileStream fileStream) {}
    public static void Deserialize(List<Phone> phones, FileStream fileStream) {}
}