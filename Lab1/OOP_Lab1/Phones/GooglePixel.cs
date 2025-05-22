namespace OOP_Lab1.Phones;

class GooglePixel : Android
{
    public GooglePixel()
    {
        /*storage = 128;
        color = "Black";
        price = 1000;*/
        imagePath = "C:\\Users\\maxbe\\OneDrive\\Документы\\OOP\\Lab1\\OOP_Lab1\\images\\google_pixel.jpg";
        //companyName = "Google";
        newImagePath = "C:\\Users\\maxbe\\OneDrive\\Документы\\OOP\\Lab1\\OOP_Lab1\\images\\Google_logo.jpg";
        model = "Google Pixel 9 Pro";
    }

    public override string ToString()
    {
        return base.ToString();
    }
    
    public override Phone Clone() => (Phone)MemberwiseClone();
    
}