using System.Runtime.Serialization;
using OOP_Lab1.Phones;
using serialization;

namespace OOP_Lab1;
using System.Reflection;

public partial class ShowPhonesForm : Form
{
    public ShowPhonesForm()
    {
        InitializeComponent();
    }
    
    private Stack<List<Phones.Phone>> undoStack = new Stack<List<Phones.Phone>>();
    private Stack<List<Phones.Phone>> redoStack = new Stack<List<Phones.Phone>>();
    public static Assembly PluginAssembly = Assembly.GetExecutingAssembly();
    private void LoadImages()
    {
        int imgKey = 0;
        foreach (var phone in Program.phonesList)
        {
            Image img = Image.FromFile(phone.newImagePath);
            imageList.Images.Add(imgKey.ToString(), img); 
            imgKey++;
        }
    }

    private void CheckEnabled(ToolStripMenuItem button, Stack<List<Phones.Phone>> stack)
    {
        if (stack.Count > 0)
        {
            button.Enabled = true;
        }
        else
        {
            button.Enabled = false;
        }
    }
    
    public void SaveState()
    {
        List<Phones.Phone> copy = new List<Phones.Phone>(Program.phonesList.Count);
        foreach (Phones.Phone phone in Program.phonesList)
        {
            Phones.Phone phoneCopy = phone.Clone();
            copy.Add(phoneCopy);
        }
        undoStack.Push(copy);
        
        //undoStack.Push(new List<Phones.Phones>(Program.phonesList));
        CheckEnabled(undo, undoStack);
        CheckEnabled(redoButton, redoStack);

    }

    private void AddAllPhones()
    {
        PhonesListView.SmallImageList = imageList;
        int count = 0;
        foreach (var phone in Program.phonesList)
        {
            if (File.Exists(phone.newImagePath))
            {
                ListViewItem item = new ListViewItem();
                item.Text = phone.model;
                item.ImageIndex = count++;
                PhonesListView.Items.Add(phone.model, item.ImageIndex);

            }
        }
    }

    private void UpdateListView()
    {
        PhonesListView.Items.Clear();
        imageList.Images.Clear();
        LoadImages();
        AddAllPhones();
    }

    private void AddPhoneButtonClick(object sender, EventArgs e)
    {
        SaveState();
        AddPhoneForm addPhoneForm = new AddPhoneForm();
        addPhoneForm.ShowDialog();
        UpdateListView();
        
    }

    private void DeleteButtonClick(object sender, EventArgs e)
    {
        if (PhonesListView.SelectedItems.Count == 0)
        {
            MessageBox.Show("Не выбран телефон.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        SaveState();
        ListViewItem selectedItem = PhonesListView.SelectedItems[0];
        int index = selectedItem.Index;
        if (index >= 0 && index < Program.phonesList.Count)
        {
            Program.phonesList.RemoveAt(index);
        }
        UpdateListView();
    }

    private void EditButtonClick(object sender, EventArgs e)
    {
        if (PhonesListView.SelectedItems.Count == 0)
        {
            MessageBox.Show("Пожалуйста, выберите телефон.", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        SaveState();
        ListViewItem selectedItem = PhonesListView.SelectedItems[0];
        int index = selectedItem.Index;
        if (index >= 0 && index < Program.phonesList.Count)
        {
            EditPhoneForm editPhoneForm = new EditPhoneForm(Program.phonesList[index]);
            editPhoneForm.ShowDialog();
        }
    }

    private void undoButtonClick(object sender, EventArgs e)
    {
        if (undoStack.Count > 0)
        {
            List<Phones.Phone> copy = new List<Phones.Phone>(Program.phonesList.Count);
            foreach (Phones.Phone phone in Program.phonesList)
            {
                Phone phoneCopy = phone.Clone(); 
                copy.Add(phoneCopy);
            }
            redoStack.Push(copy); // Сохраняем текущее состояние
            //redoStack.Push(Program.phonesList);
            Program.phonesList = undoStack.Pop(); // Откатываем предыдущее состояние
            UpdateListView();
            CheckEnabled(undo, undoStack);
            CheckEnabled(redoButton, redoStack);
        }
    }

    private void redoButtonClick(object sender, EventArgs e)
    {
        if (redoStack.Count > 0)
        {
            List<Phones.Phone> copy = new List<Phones.Phone>(Program.phonesList.Count);
            foreach (Phones.Phone phone in Program.phonesList)
            {
                Phone phoneCopy = phone.Clone();
                copy.Add(phoneCopy);
            }
            
            undoStack.Push(copy); // Сохраняем текущее состояние
            //undoStack.Push(Program.phonesList);
            Program.phonesList = redoStack.Pop(); // Восстанавливаем состояние
            UpdateListView();
            CheckEnabled(undo, undoStack);
            CheckEnabled(redoButton, redoStack);
        }
    }

    private void InfoButtonClick(object sender, EventArgs e)
    {
        ListViewItem selectedItem = PhonesListView.SelectedItems[0];
        int index = selectedItem.Index;
        ShowPropertiesForm showPropertiesForm = new ShowPropertiesForm(Program.phonesList[index]);
        showPropertiesForm.ShowDialog();
    }

    private void ListViewSelect(object sender, EventArgs e)
    {
        if (PhonesListView.SelectedItems.Count > 0)
        {
            DeleteButton.Enabled = true;
            EditPhoneButton.Enabled = true;
            InfoButton.Enabled = true;
        }
        else
        {
            DeleteButton.Enabled = false;
            EditPhoneButton.Enabled = false;
            InfoButton.Enabled = false;
        }
    }

    private void ShowForm(object sender, EventArgs e)
    {
        LoadImages();
        AddAllPhones();
    }

    private void saveFileButton_Click(object sender, EventArgs e)
    {
        /*if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            Serialization serializer = new Serialization();
            serializer.Serialize(Program.phonesList, saveFileDialog.FileName + ".json");
        }*/
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            Serialization.Serialize(saveFileDialog.FileName);
        }
    }

    private void openFileButton_Click(object sender, EventArgs e)
    {
        SaveState();
        /*try
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Serialization deserializer = new Serialization();
                Program.phonesList = deserializer.Deserialize(openFileDialog.FileName);
                UpdateListView();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при десериализации: {ex.Message}", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }*/
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            Serialization.Deserialize(openFileDialog.FileName);
        }
    }

    private void addClassButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialogDll = new OpenFileDialog();
        openFileDialogDll.Filter = "DLL files (*.dll)|*.dll";
        openFileDialogDll.Title = "Выберите DLL плагина";

        if (openFileDialogDll.ShowDialog() == DialogResult.OK)
        {
            PluginAssembly = Assembly.LoadFrom(openFileDialogDll.FileName);
            var pluginTypes = PluginAssembly.GetTypes()
                .Where(t => typeof(Phone).IsAssignableFrom(t) && !t.IsAbstract).ToArray();
            AddPhoneForm.PhoneTypeNames = AddPhoneForm.PhoneTypeNames
                .Concat(pluginTypes
                    .Where(t => !AddPhoneForm.PhoneTypeNames.Contains(t.Name))  // Проверка на существование
                    .Select(t => t.Name))
                .ToArray();

        }
    }

    private void AddActionButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialogDll = new OpenFileDialog();
        openFileDialogDll.Filter = "DLL files (*.dll)|*.dll";
        openFileDialogDll.Title = "Выберите DLL плагина";
        if (openFileDialogDll.ShowDialog() == DialogResult.OK)
        {
            Assembly.LoadFrom(openFileDialogDll.FileName);

            System.Type[] allTypes = Types.Types.GetTypes();
            var baseType = typeof(ISerializer);
            foreach (var type in allTypes)
            {
                if (!type.IsInterface && baseType.IsAssignableFrom(type))
                {
                    Serialization.extraSerialize = (Serialization.ExtraSerialize)type.GetMethod("Serialize")!.CreateDelegate(typeof(Serialization.ExtraSerialize));
                    Serialization.extraDeserialize = (Serialization.ExtraDeserialize)type.GetMethod("Deserialize")!.CreateDelegate(typeof(Serialization.ExtraDeserialize));
                }
            }
        }
    }
}