namespace OOP_Lab1.Phones;

class Samsung : Android
{
    public Samsung()
    {
        /*storage = 512;
        color = "Titanium Grey";
        price = 1000;*/
        imagePath = "C:\\Users\\maxbe\\OneDrive\\Документы\\OOP\\Lab1\\OOP_Lab1\\images\\samsung.jpg";
       // companyName = "Samsung";
        newImagePath = "C:\\Users\\maxbe\\OneDrive\\Документы\\OOP\\Lab1\\OOP_Lab1\\images\\samsung_logo.jpg";
        model = "Samsung Galaxy S25 Ultra";
    }
    
    public override Phone Clone() => (Phone)MemberwiseClone();
}