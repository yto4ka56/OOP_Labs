namespace OOP_Lab1;

public partial class ShowPropertiesForm : Form
{
    private Phones.Phone _currPhone;

    public ShowPropertiesForm(Phones.Phone phone)
    {
        InitializeComponent();
        _currPhone = phone;
        InfoLabel.Text = _currPhone.ToString();
    }
}