using System.ComponentModel;

namespace OOP_Lab1;

partial class EditPhoneForm
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
        SaveButton = new System.Windows.Forms.Button();
        NameLabel = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // SaveButton
        // 
        SaveButton.Location = new System.Drawing.Point(573, 318);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new System.Drawing.Size(184, 67);
        SaveButton.TabIndex = 0;
        SaveButton.Text = "Сохранить";
        SaveButton.UseVisualStyleBackColor = true;
        SaveButton.Click += SaveButtonClick;
        // 
        // NameLabel
        // 
        NameLabel.Location = new System.Drawing.Point(63, 54);
        NameLabel.Name = "NameLabel";
        NameLabel.Size = new System.Drawing.Size(157, 58);
        NameLabel.TabIndex = 1;
        NameLabel.Text = "label1";
        // 
        // EditPhoneForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(NameLabel);
        Controls.Add(SaveButton);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Изменить свойства";
        Load += EditPhoneFormLoad;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label NameLabel;

    private System.Windows.Forms.Button SaveButton;

    #endregion
}