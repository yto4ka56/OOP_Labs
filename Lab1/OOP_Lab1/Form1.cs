 using OOP_Lab1.Phones.Android;
 using OOP_Lab1.Phones.iPhone;

 namespace OOP_Lab1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        List<PictureBox> phonesBoxList = new List<PictureBox>()
        {
            pictureBox1,
            pictureBox2,
            pictureBox3,
            pictureBox4
        };

        List<Label> labelsList = new List<Label>()
        {
            label2,
            label3,
            label4,
            label5
        };

        List<Phones.Phones> phonesList = new List<Phones.Phones>()
        {
            new iPhone(),
            new Samsung(),
            new Huawei(),
            new GooglePixel()
        };

        for (int i = 0; i < 4; i++)
        {
            printInfo(phonesList[i],phonesBoxList[i], labelsList[i]);
        }
        
    }

    private void printInfo(Phones.Phones phone, PictureBox pictureBox, Label label)
    {
        label.Text = phone.model +"\n"+ phone.color + "\n" + phone.price;
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox.Image = Image.FromFile(phone.imagePath);
    }
    
    
}