using OOP_Lab1.Phones;

namespace ExtraPhonePlugin;

public class Nokia: Phone
{
    public Nokia()
    {
        newImagePath = "C:\\Users\\maxbe\\OneDrive\\Документы\\OOP\\Lab1\\OOP_Lab1\\images\\nokia_logo.png";
        imagePath = "C:\\Users\\maxbe\\OneDrive\\Документы\\OOP\\Lab1\\OOP_Lab1\\images\\nokia_logo.png";
    }
    
    public override Phone Clone() => (Phone)MemberwiseClone();
}