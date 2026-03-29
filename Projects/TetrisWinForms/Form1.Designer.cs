namespace TetrisWinForms;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private Label labelAuthor;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        labelAuthor = new Label();
        SuspendLayout();
        // 
        // labelAuthor
        // 
        labelAuthor.AutoSize = true;
        labelAuthor.Font = new Font("Segoe UI", 16F);
        labelAuthor.ForeColor = Color.FromArgb(73, 80, 87);
        labelAuthor.Location = new Point(12, 18);
        labelAuthor.Name = "labelAuthor";
        labelAuthor.Size = new Size(394, 30);
        labelAuthor.TabIndex = 1;
        labelAuthor.Text = "Автор: Благодатских Антон Иванович";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 250);
        ClientSize = new Size(640, 360);
        Controls.Add(labelAuthor);
        Font = new Font("Segoe UI", 11F);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Лабораторная работа №1";
        ResumeLayout(false);
        PerformLayout();
    }
}
