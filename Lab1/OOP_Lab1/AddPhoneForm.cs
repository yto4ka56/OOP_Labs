using System.Reflection;

namespace OOP_Lab1;

public partial class AddPhoneForm : Form
{
    private Type phoneType;
    private Form1 mainForm;
    
    public AddPhoneForm()
    {
        InitializeComponent();
        LoadPhonesTypes();
    }
    
     private void LoadPhonesTypes()
    {
        var phonesTypes = typeof(Phones.Phones).Assembly.GetTypes()  
            .Where(t => t.IsSubclassOf(typeof(Phones.Phones)) && !t.IsAbstract) //  наследники Flower
            .Select(t => t.Name)
            .ToArray();
        phonesComboBox.Items.AddRange(phonesTypes);
    }

    private Dictionary<string, object> GetProperties(Type type)
    {
        Dictionary<string, object> enteredProperties = new Dictionary<string, object>();
        
        Panel panel = Controls.OfType<Panel>().FirstOrDefault(p => p.Name == "propertiesPanel");
        if (panel == null)
        {
            MessageBox.Show("Панель со свойствами не найдена!");
            return enteredProperties;
        }

        foreach (var property in type.GetProperties())
        {
            string propertyName = property.Name;
            Control inputControl = panel.Controls[$"{propertyName}TextBox"] ?? panel.Controls[$"{propertyName}ComboBox"];

            if (inputControl is TextBox textBox && !string.IsNullOrEmpty(textBox.Text))
            {
                try
                {
                    object convertedValue = Convert.ChangeType(textBox.Text, property.PropertyType);
                    enteredProperties[propertyName] = convertedValue;
                }
                catch (Exception)
                {
                    MessageBox.Show($"Ошибка преобразования для {propertyName}. Проверьте формат данных.");
                }
            }
            else if (inputControl is ComboBox comboBox)
            {
                if (property.PropertyType == typeof(bool))
                {
                    enteredProperties[propertyName] = comboBox.SelectedItem.ToString() == "True";
                }
                else
                {
                    enteredProperties[propertyName] = comboBox.SelectedItem.ToString();
                }
            }
        }

        return enteredProperties;
    }
    
    
    bool HasEmptyFields(object obj)
    {
        foreach (PropertyInfo prop in obj.GetType().GetProperties())
        {
            object value = prop.GetValue(obj);

            if (value == null || 
                (value is string str && string.IsNullOrWhiteSpace(str)) || 
                (value is int num && num == 0))
            {
                return true; 
            }
        }
        return false; 
    }

    
    private void AddButtonClick(object sender, EventArgs e)
    {
        string stringType = phonesComboBox.SelectedItem.ToString() ?? string.Empty;

        Type phonesType = Type.GetType("OOP_Lab1.Phones." + stringType) ?? typeof(object);
        Dictionary<string, object> properties = GetProperties(phonesType);
        object phonesInstance = Activator.CreateInstance(phonesType) ;

        bool hasError = false;
        foreach (var property in properties)
        {
            PropertyInfo propInfo = phonesType.GetProperty(property.Key);
            try
            {
                object convertedValue = Convert.ChangeType(property.Value, propInfo.PropertyType);
                propInfo.SetValue(phonesInstance, convertedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при установке свойства {property.Key}\nПопробуйте еще раз");
                hasError = true;
            }    
        }
        if (!hasError && HasEmptyFields(phonesInstance))
        {
            MessageBox.Show("Некоторые поля пустые. Заполните их перед добавлением.");
            hasError = true;
        }

        if (!hasError)
        {
            Program.phonesList.Add((Phones.Phones)phonesInstance);
            Close();
        }

    }
    
    private Panel CreatePropertiesPanel()
    {
        Panel panel = new Panel
        {
            AutoSize = true,
            Location = new Point(0, 0),
            Name = "propertiesPanel"
        };
        return panel;
    }
    
    private Label CreateLabel(string propertyName, int x, int y, Size size)
    {
        return new Label
        {
            Text = propertyName,
            Location = new Point(x, y),
            Name = $"{propertyName}Label",
            Size = size
        };
    }
    
    private ComboBox CreateComboBox(string propertyName, int x, int y, Size size)
    {
        return new ComboBox
        {
            Items = { "True", "False" },
            DropDownStyle = ComboBoxStyle.DropDownList,
            SelectedIndex = 0,
            Location = new Point(x, y),
            Name = $"{propertyName}ComboBox",
            Size = size
        };
    }
    
    private TextBox CreateTextBox(string propertyName, int x, int y, Size size)
    {
        return new TextBox
        {
            Location = new Point(x, y),
            Name = $"{propertyName}TextBox",
            Size = size
        };
    }

    private void AddProperties(List<PropertyInfo> properties)
    {
        int offset = 50;
        int labelX = 30, labelY = 280;
        int textX = 280, textY= 280;
        int startX = 0, startY = 0;
        Size size = new Size(170, 30);
        Panel panel = CreatePropertiesPanel();
        
        
        foreach (var property in properties)
        {
            Label label = CreateLabel(property.Name, labelX, labelY, size);
            
            Control inputControl;
            
            
            if (property.PropertyType == typeof(bool))
            {
                ComboBox comboBox = CreateComboBox(property.Name, textX, textY, size);
                panel.Controls.Add(comboBox);
                inputControl = comboBox;
            }
            else
            {
                TextBox textBox = CreateTextBox(property.Name, textX, textY, size);
                panel.Controls.Add(textBox);
                inputControl = textBox;
            }
            panel.Controls.Add(label);
            panel.Controls.Add(inputControl);
            
            textY +=  offset;
            labelY += offset;
            
        }
        Controls.Add(panel);
        
    }

    private void ClearPanel()
    {
        var panel = Controls.OfType<Panel>().FirstOrDefault(p => p.Name == "propertiesPanel");
    
        if (panel != null)
        {
            Controls.Remove(panel); 
            panel.Dispose();
        }
    }

    private void ComboBoxChanged(object sender, EventArgs e)
    {
        ClearPanel();
        if (phonesComboBox.SelectedItem == null) return;
        AddButton.Visible = true;
        string stringType = phonesComboBox.SelectedItem.ToString() ?? string.Empty;
        if (stringType != string.Empty)
        {
            Type phonesType = Assembly.GetExecutingAssembly().GetType("OOP_Lab1.Phones." + stringType) ?? typeof(Phones.Phones);
            
            List<PropertyInfo> propNames = phonesType.GetProperties(
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.FlattenHierarchy
            ).Where(prop => prop.Name != "newImagePath" && prop.Name != "imagePath").ToList();
            AddProperties(propNames);

        }
    }
}