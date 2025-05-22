namespace OOP_Lab1.Phones;

class IPhone : Phone
{
    public bool hasAI{ get; set; }
    public IPhone()
    {
        imagePath = "C:\\Users\\maxbe\\OneDrive\\Документы\\OOP\\Lab1\\OOP_Lab1\\images\\iphone_14_pro_max.jpg";
        //color = "Space Grey";
        model = "iPhone 14 Pro Max";
        newImagePath = "C:\\Users\\maxbe\\OneDrive\\Документы\\OOP\\Lab1\\OOP_Lab1\\images\\apple_logo.png";
        /*price = 1400;
        hasAI = false;*/
    }

    public IPhone(bool hasAI)
    {
        hasAI = hasAI;
    }

    public override string ToString()
    {
        return base.ToString() + $", HasAI: {hasAI}";
    }

    public override Phone Clone() => (Phone)MemberwiseClone();
}