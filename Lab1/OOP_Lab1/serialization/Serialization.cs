using OOP_Lab1.Phones;

namespace OOP_Lab1;

public interface ISerializer
{
    void Serialize(List<Phone> phones, string filePath);
    List<Phone> Deserialize(string filePath);
}