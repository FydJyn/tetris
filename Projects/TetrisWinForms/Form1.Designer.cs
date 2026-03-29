namespace TetrisWinForms;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private Label labelTitle;
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
        components = new System.ComponentModel.Container();
        labelTitle = new Label();
        labelAuthor = new Label();
        SuspendLayout();

        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 250);
        ClientSize = new Size(640, 360);
        Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Лабораторная работа №1";

        labelTitle.AutoSize = true;
        labelTitle.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
        labelTitle.ForeColor = Color.FromArgb(33, 37, 41);
        labelTitle.Location = new Point(78, 84);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(249, 54);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "Tetris WinForms";

        labelAuthor.AutoSize = true;
        labelAuthor.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        labelAuthor.ForeColor = Color.FromArgb(73, 80, 87);
        labelAuthor.Location = new Point(78, 156);
        labelAuthor.Name = "labelAuthor";
        labelAuthor.Size = new Size(458, 37);
        labelAuthor.TabIndex = 1;
        labelAuthor.Text = "Автор: Благодатских Антон Иванович";

        Controls.Add(labelAuthor);
        Controls.Add(labelTitle);
        Name = "Form1";

        ResumeLayout(false);
        PerformLayout();
    }
}
