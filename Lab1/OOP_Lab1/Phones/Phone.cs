

namespace OOP_Lab1.Phones;


public abstract class Phone
{
    public string color { get; set; }
    public int price{ get; set; }
    public string imagePath{ get; set; }
    public string newImagePath { get; set; }
    public string model{ get; set; }

   // public static int CountPhones { get; private set; } = 0;
   
    public Phone()
    {
        //CountPhones++;
    }

    public abstract Phone Clone();

    public override string ToString()
    {
        return $"Color: {color}, Price {price} USD, Model {model}";
    }
}