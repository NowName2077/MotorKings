namespace MotorKings_Interface;

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
        listBox1 = new System.Windows.Forms.ListBox();
        button1 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 15;
        listBox1.Location = new System.Drawing.Point(11, 12);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(141, 349);
        listBox1.TabIndex = 0;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(158, 12);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(115, 45);
        button1.TabIndex = 1;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click_1;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(button1);
        Controls.Add(listBox1);
        Text = "Form1";
        ResumeLayout(false);
    }

    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Button button1;

    #endregion
}