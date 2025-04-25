using System.ComponentModel;

namespace OOP_Lab1;

partial class AddPhoneForm
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
        label1 = new System.Windows.Forms.Label();
        phonesComboBox = new System.Windows.Forms.ComboBox();
        AddButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 14F);
        label1.Location = new System.Drawing.Point(79, 90);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(154, 54);
        label1.TabIndex = 0;
        label1.Text = "Бренд:";
        // 
        // phonesComboBox
        // 
        phonesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        phonesComboBox.Font = new System.Drawing.Font("Segoe UI", 13F);
        phonesComboBox.FormattingEnabled = true;
        phonesComboBox.Location = new System.Drawing.Point(282, 90);
        phonesComboBox.Name = "phonesComboBox";
        phonesComboBox.Size = new System.Drawing.Size(261, 55);
        phonesComboBox.TabIndex = 1;
        phonesComboBox.SelectedIndexChanged += ComboBoxChanged;
        // 
        // AddButton
        // 
        AddButton.Font = new System.Drawing.Font("Segoe UI", 12F);
        AddButton.Location = new System.Drawing.Point(321, 812);
        AddButton.Name = "AddButton";
        AddButton.Size = new System.Drawing.Size(189, 84);
        AddButton.TabIndex = 2;
        AddButton.Text = "Добавить";
        AddButton.UseVisualStyleBackColor = true;
        AddButton.Click += AddButtonClick;
        // 
        // AddPhoneForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(818, 948);
        Controls.Add(AddButton);
        Controls.Add(phonesComboBox);
        Controls.Add(label1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Добавить телефон";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button AddButton;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox phonesComboBox;

    #endregion
}