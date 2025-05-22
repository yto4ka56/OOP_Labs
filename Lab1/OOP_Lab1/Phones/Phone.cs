namespace OOP_Lab1.Phones;

public abstract class Phones
{
    public string color { get; set; }
    public int price{ get; set; }
    public string imagePath{ get; set; }
    public string newImagePath { get; set; }
    public string model{ get; set; }

    public static int CountPhones { get; private set; } = 0;

    public Phones()
    {
        CountPhones++;
    }

    static Phones()
    {
        CountPhones = 0;
    }

    public override string ToString()
    {
        return $"Color: {color}, Price {price} USD, Model {model}";
    }
}