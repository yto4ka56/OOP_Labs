namespace OOP_Lab1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        pictureBox1 = new System.Windows.Forms.PictureBox();
        pictureBox3 = new System.Windows.Forms.PictureBox();
        pictureBox2 = new System.Windows.Forms.PictureBox();
        pictureBox4 = new System.Windows.Forms.PictureBox();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        MyPhonesButton = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(387, 28);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(492, 111);
        label1.TabIndex = 0;
        label1.Text = "Список смартфонов";
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new System.Drawing.Point(81, 142);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(234, 287);
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // pictureBox3
        // 
        pictureBox3.Location = new System.Drawing.Point(673, 142);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new System.Drawing.Size(234, 287);
        pictureBox3.TabIndex = 3;
        pictureBox3.TabStop = false;
        // 
        // pictureBox2
        // 
        pictureBox2.Location = new System.Drawing.Point(364, 142);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new System.Drawing.Size(234, 287);
        pictureBox2.TabIndex = 4;
        pictureBox2.TabStop = false;
        // 
        // pictureBox4
        // 
        pictureBox4.Location = new System.Drawing.Point(969, 142);
        pictureBox4.Name = "pictureBox4";
        pictureBox4.Size = new System.Drawing.Size(234, 287);
        pictureBox4.TabIndex = 5;
        pictureBox4.TabStop = false;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(81, 465);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(234, 291);
        label2.TabIndex = 6;
        label2.Text = "label2";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(364, 465);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(234, 291);
        label3.TabIndex = 7;
        label3.Text = "label3";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(673, 465);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(234, 291);
        label4.TabIndex = 8;
        label4.Text = "label4";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(969, 465);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(234, 291);
        label5.TabIndex = 9;
        label5.Text = "label5";
        // 
        // MyPhonesButton
        // 
        MyPhonesButton.Font = new System.Drawing.Font("Segoe UI", 14F);
        MyPhonesButton.Location = new System.Drawing.Point(448, 566);
        MyPhonesButton.Name = "MyPhonesButton";
        MyPhonesButton.Size = new System.Drawing.Size(392, 87);
        MyPhonesButton.TabIndex = 10;
        MyPhonesButton.Text = "Мои телефоны";
        MyPhonesButton.UseVisualStyleBackColor = true;
        MyPhonesButton.Click += MyPhonesButtonClick;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1277, 694);
        Controls.Add(MyPhonesButton);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(pictureBox4);
        Controls.Add(pictureBox2);
        Controls.Add(pictureBox3);
        Controls.Add(pictureBox1);
        Controls.Add(label1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Smartphones";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button MyPhonesButton;

    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.PictureBox pictureBox4;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Label label1;

    #endregion
}