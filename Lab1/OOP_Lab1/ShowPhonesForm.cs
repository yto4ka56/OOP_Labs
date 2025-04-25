namespace OOP_Lab1;

public partial class ShowPhonesForm : Form
{
    public ShowPhonesForm()
    {
        InitializeComponent();
    }
    
     private Stack<List<Phones.Phones>> undoStack = new Stack<List<Phones.Phones>>();
    private Stack<List<Phones.Phones>> redoStack = new Stack<List<Phones.Phones>>();
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

    private void CheckEnabled(ToolStripMenuItem button, Stack<List<Phones.Phones>> stack)
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
    
    private void SaveState()
    {
        List<Phones.Phones> copy = new List<Phones.Phones>(Program.phonesList.Count);
        foreach (Phones.Phones phone in Program.phonesList)
        {
            copy.Add(phone);
        }
        undoStack.Push(copy);
        
        CheckEnabled(undoButton, undoStack);
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
            List<Phones.Phones> copy = new List<Phones.Phones>(Program.phonesList.Count);
            foreach (Phones.Phones phone in Program.phonesList)
            {
                copy.Add(phone);
            }
            redoStack.Push(copy); // Сохраняем текущее состояние
            Program.phonesList = undoStack.Pop(); // Откатываем предыдущее состояние
            UpdateListView();
            CheckEnabled(undoButton, undoStack);
            CheckEnabled(redoButton, redoStack);
        }
    }

    private void redoButtonClick(object sender, EventArgs e)
    {
        if (redoStack.Count > 0)
        {
            List<Phones.Phones> copy = new List<Phones.Phones>(Program.phonesList.Count);
            foreach (Phones.Phones phone in Program.phonesList)
            {
                copy.Add(phone);
            }

            
            
            undoStack.Push(copy); // Сохраняем текущее состояние
            Program.phonesList = redoStack.Pop(); // Восстанавливаем состояние
            UpdateListView();
            CheckEnabled(undoButton, undoStack);
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
}