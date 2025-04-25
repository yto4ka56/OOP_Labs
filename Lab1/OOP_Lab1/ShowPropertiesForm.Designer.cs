using System.ComponentModel;

namespace OOP_Lab1;

partial class ShowPropertiesForm
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
        InfoLabel = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // InfoLabel
        // 
        InfoLabel.Location = new System.Drawing.Point(131, 112);
        InfoLabel.Name = "InfoLabel";
        InfoLabel.Size = new System.Drawing.Size(532, 177);
        InfoLabel.TabIndex = 0;
        // 
        // ShowPropertiesForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(InfoLabel);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Свойства";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label InfoLabel;

    #endregion
}