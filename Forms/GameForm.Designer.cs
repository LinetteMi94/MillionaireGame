using System.ComponentModel;

namespace MillionaireGame.Forms;

partial class GameForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
        textBox_Answer = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // textBox_Answer
        // 
        textBox_Answer.Location = new System.Drawing.Point(145, 197);
        textBox_Answer.Name = "textBox_Answer";
        textBox_Answer.Size = new System.Drawing.Size(422, 27);
        textBox_Answer.TabIndex = 0;
        // 
        // GameForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackgroundImage = ((System.Drawing.Image)resources.GetObject("$this.BackgroundImage"));
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(textBox_Answer);
        Text = "Игра \"Кто хочет стать миллионером\"";
        Load += GameForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBox_Answer;

    #endregion
}