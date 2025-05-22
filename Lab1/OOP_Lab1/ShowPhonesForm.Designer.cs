using System.ComponentModel;

namespace OOP_Lab1;

partial class ShowPhonesForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowPhonesForm));
        AddPhoneButton = new System.Windows.Forms.Button();
        EditPhoneButton = new System.Windows.Forms.Button();
        DeleteButton = new System.Windows.Forms.Button();
        PhonesListView = new System.Windows.Forms.ListView();
        imageList = new System.Windows.Forms.ImageList(components);
        InfoButton = new System.Windows.Forms.Button();
        undoButton = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        повторДействияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        openFileButton = new System.Windows.Forms.ToolStripMenuItem();
        saveFileButton = new System.Windows.Forms.ToolStripMenuItem();
        правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        undo = new System.Windows.Forms.ToolStripMenuItem();
        redoButton = new System.Windows.Forms.ToolStripMenuItem();
        openFileDialog = new System.Windows.Forms.OpenFileDialog();
        saveFileDialog = new System.Windows.Forms.SaveFileDialog();
        addClassButton = new System.Windows.Forms.Button();
        AddActionButton = new System.Windows.Forms.Button();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // AddPhoneButton
        // 
        AddPhoneButton.Font = new System.Drawing.Font("Segoe UI", 12F);
        AddPhoneButton.Location = new System.Drawing.Point(89, 58);
        AddPhoneButton.Name = "AddPhoneButton";
        AddPhoneButton.Size = new System.Drawing.Size(226, 77);
        AddPhoneButton.TabIndex = 0;
        AddPhoneButton.Text = "Добавить";
        AddPhoneButton.UseVisualStyleBackColor = true;
        AddPhoneButton.Click += AddPhoneButtonClick;
        // 
        // EditPhoneButton
        // 
        EditPhoneButton.Font = new System.Drawing.Font("Segoe UI", 12F);
        EditPhoneButton.Location = new System.Drawing.Point(370, 58);
        EditPhoneButton.Name = "EditPhoneButton";
        EditPhoneButton.Size = new System.Drawing.Size(254, 77);
        EditPhoneButton.TabIndex = 1;
        EditPhoneButton.Text = "Редактировать";
        EditPhoneButton.UseVisualStyleBackColor = true;
        EditPhoneButton.Click += EditButtonClick;
        // 
        // DeleteButton
        // 
        DeleteButton.Font = new System.Drawing.Font("Segoe UI", 12F);
        DeleteButton.Location = new System.Drawing.Point(664, 58);
        DeleteButton.Name = "DeleteButton";
        DeleteButton.Size = new System.Drawing.Size(265, 77);
        DeleteButton.TabIndex = 2;
        DeleteButton.Text = "Удалить";
        DeleteButton.UseVisualStyleBackColor = true;
        DeleteButton.Click += DeleteButtonClick;
        // 
        // PhonesListView
        // 
        PhonesListView.LargeImageList = imageList;
        PhonesListView.Location = new System.Drawing.Point(118, 216);
        PhonesListView.Name = "PhonesListView";
        PhonesListView.Size = new System.Drawing.Size(1083, 583);
        PhonesListView.SmallImageList = imageList;
        PhonesListView.TabIndex = 3;
        PhonesListView.UseCompatibleStateImageBehavior = false;
        PhonesListView.View = System.Windows.Forms.View.SmallIcon;
        PhonesListView.SelectedIndexChanged += ListViewSelect;
        // 
        // imageList
        // 
        imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
        imageList.ImageSize = new System.Drawing.Size(100, 100);
        imageList.TransparentColor = System.Drawing.Color.Transparent;
        // 
        // InfoButton
        // 
        InfoButton.Font = new System.Drawing.Font("Segoe UI", 12F);
        InfoButton.Location = new System.Drawing.Point(957, 58);
        InfoButton.Name = "InfoButton";
        InfoButton.Size = new System.Drawing.Size(265, 77);
        InfoButton.TabIndex = 5;
        InfoButton.Text = "Свойства";
        InfoButton.UseVisualStyleBackColor = true;
        InfoButton.Click += InfoButtonClick;
        // 
        // undoButton
        // 
        undoButton.Name = "undoButton";
        undoButton.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
        undoButton.Size = new System.Drawing.Size(316, 34);
        undoButton.Text = "&Отмена действия";
        undoButton.Click += undoButtonClick;
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
        // 
        // повторДействияToolStripMenuItem
        // 
        повторДействияToolStripMenuItem.Name = "повторДействияToolStripMenuItem";
        повторДействияToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
        повторДействияToolStripMenuItem.Text = "Повтор действия";
        // 
        // toolStripMenuItem2
        // 
        toolStripMenuItem2.Name = "toolStripMenuItem2";
        toolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { файлToolStripMenuItem, правкаToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(1312, 33);
        menuStrip1.TabIndex = 6;
        menuStrip1.Text = "menuStrip1";
        // 
        // файлToolStripMenuItem
        // 
        файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openFileButton, saveFileButton });
        файлToolStripMenuItem.Name = "файлToolStripMenuItem";
        файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
        файлToolStripMenuItem.Text = "&Файл";
        // 
        // openFileButton
        // 
        openFileButton.Image = ((System.Drawing.Image)resources.GetObject("openFileButton.Image"));
        openFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        openFileButton.Name = "openFileButton";
        openFileButton.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
        openFileButton.Size = new System.Drawing.Size(261, 34);
        openFileButton.Text = "&Открыть";
        openFileButton.Click += openFileButton_Click;
        // 
        // saveFileButton
        // 
        saveFileButton.Image = ((System.Drawing.Image)resources.GetObject("saveFileButton.Image"));
        saveFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        saveFileButton.Name = "saveFileButton";
        saveFileButton.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
        saveFileButton.Size = new System.Drawing.Size(261, 34);
        saveFileButton.Text = "Со&хранить";
        saveFileButton.Click += saveFileButton_Click;
        // 
        // правкаToolStripMenuItem
        // 
        правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { undo, redoButton });
        правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
        правкаToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
        правкаToolStripMenuItem.Text = "&Правка";
        // 
        // undo
        // 
        undo.Name = "undo";
        undo.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
        undo.Size = new System.Drawing.Size(316, 34);
        undo.Text = "&Отмена действия";
        undo.Click += undoButtonClick;
        // 
        // redoButton
        // 
        redoButton.Name = "redoButton";
        redoButton.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y));
        redoButton.Size = new System.Drawing.Size(316, 34);
        redoButton.Text = "&Повтор действия";
        redoButton.Click += redoButtonClick;
        // 
        // addClassButton
        // 
        addClassButton.Font = new System.Drawing.Font("Segoe UI", 12F);
        addClassButton.Location = new System.Drawing.Point(338, 836);
        addClassButton.Name = "addClassButton";
        addClassButton.Size = new System.Drawing.Size(226, 77);
        addClassButton.TabIndex = 7;
        addClassButton.Text = "Добавить класс";
        addClassButton.UseVisualStyleBackColor = true;
        addClassButton.Click += addClassButton_Click;
        // 
        // AddActionButton
        // 
        AddActionButton.Font = new System.Drawing.Font("Segoe UI", 12F);
        AddActionButton.Location = new System.Drawing.Point(756, 836);
        AddActionButton.Name = "AddActionButton";
        AddActionButton.Size = new System.Drawing.Size(226, 77);
        AddActionButton.TabIndex = 8;
        AddActionButton.Text = "Добавить действие";
        AddActionButton.UseVisualStyleBackColor = true;
        // 
        // ShowPhonesForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1312, 958);
        Controls.Add(AddActionButton);
        Controls.Add(addClassButton);
        Controls.Add(InfoButton);
        Controls.Add(PhonesListView);
        Controls.Add(DeleteButton);
        Controls.Add(EditPhoneButton);
        Controls.Add(AddPhoneButton);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Margin = new System.Windows.Forms.Padding(2);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Мои телефоны";
        Load += ShowForm;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button addClassButton;
    private System.Windows.Forms.Button AddActionButton;

    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.SaveFileDialog saveFileDialog;

    private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openFileButton;
    private System.Windows.Forms.ToolStripMenuItem saveFileButton;
    private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem undo;
    private System.Windows.Forms.ToolStripMenuItem redoButton;

    private System.Windows.Forms.MenuStrip menuStrip1;

    private System.Windows.Forms.ToolStripMenuItem повторДействияToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

    private System.Windows.Forms.Button InfoButton;

    private System.Windows.Forms.ToolStripMenuItem undoButton;

    private System.Windows.Forms.ImageList imageList;

    private System.Windows.Forms.ListView PhonesListView;

    private System.Windows.Forms.Button AddPhoneButton;
    private System.Windows.Forms.Button EditPhoneButton;
    private System.Windows.Forms.Button DeleteButton;

    #endregion
}