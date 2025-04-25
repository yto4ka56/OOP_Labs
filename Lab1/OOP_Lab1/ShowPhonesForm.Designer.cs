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
        AddPhoneButton = new System.Windows.Forms.Button();
        EditPhoneButton = new System.Windows.Forms.Button();
        DeleteButton = new System.Windows.Forms.Button();
        PhonesListView = new System.Windows.Forms.ListView();
        imageList = new System.Windows.Forms.ImageList(components);
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        undoButton = new System.Windows.Forms.ToolStripMenuItem();
        redoButton = new System.Windows.Forms.ToolStripMenuItem();
        InfoButton = new System.Windows.Forms.Button();
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
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { правкаToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(1312, 40);
        menuStrip1.TabIndex = 4;
        menuStrip1.Text = "menuStrip1";
        // 
        // правкаToolStripMenuItem
        // 
        правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { undoButton, redoButton });
        правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
        правкаToolStripMenuItem.Size = new System.Drawing.Size(114, 36);
        правкаToolStripMenuItem.Text = "&Правка";
        // 
        // undoButton
        // 
        undoButton.Name = "undoButton";
        undoButton.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
        undoButton.Size = new System.Drawing.Size(419, 44);
        undoButton.Text = "&Отмена действия";
        undoButton.Click += undoButtonClick;
        // 
        // redoButton
        // 
        redoButton.Name = "redoButton";
        redoButton.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y));
        redoButton.Size = new System.Drawing.Size(419, 44);
        redoButton.Text = "Повтор действия";
        redoButton.Click += redoButtonClick;
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
        // ShowPhonesForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1312, 866);
        Controls.Add(InfoButton);
        Controls.Add(PhonesListView);
        Controls.Add(DeleteButton);
        Controls.Add(EditPhoneButton);
        Controls.Add(AddPhoneButton);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Мои телефоны";
        Load += ShowForm;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button InfoButton;

    private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem undoButton;
    private System.Windows.Forms.ToolStripMenuItem redoButton;

    private System.Windows.Forms.MenuStrip menuStrip1;

    private System.Windows.Forms.ImageList imageList;

    private System.Windows.Forms.ListView PhonesListView;

    private System.Windows.Forms.Button AddPhoneButton;
    private System.Windows.Forms.Button EditPhoneButton;
    private System.Windows.Forms.Button DeleteButton;

    #endregion
}