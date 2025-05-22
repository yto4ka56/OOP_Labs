namespace OOP_Lab1.Phones;

abstract class Android : Phone
{
    public string companyName{ get; set; }
    public int storage{ get; set; }

    public override string ToString()
    {
        return base.ToString() + $", Company: {companyName}, Storage: {storage}";
    }

}