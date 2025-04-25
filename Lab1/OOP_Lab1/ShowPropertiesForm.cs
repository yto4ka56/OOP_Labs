namespace OOP_Lab1;

public partial class ShowPropertiesForm : Form
{
    private Phones.Phones currPhone;

    public ShowPropertiesForm(Phones.Phones phone)
    {
        InitializeComponent();
        currPhone = phone;
        InfoLabel.Text = currPhone.ToString();
    }
}