namespace OOP_Lab1.Phones;

class Huawei : Android
{
   public Huawei()
   {
      /*storage = 256;
      color = "Green";
      price = 400;*/
      imagePath = "C:\\Users\\maxbe\\OneDrive\\Документы\\OOP\\Lab1\\OOP_Lab1\\images\\huawei.jpg";
      //companyName = "Huawei";
      newImagePath = "C:\\Users\\maxbe\\OneDrive\\Документы\\OOP\\Lab1\\OOP_Lab1\\images\\huawei_logo.png";
      model = "Huawei Nova 13";
   } 
   
   public override Phone Clone() => (Phone)MemberwiseClone();
}