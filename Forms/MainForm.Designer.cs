using System.ComponentModel;

namespace MillionaireGame.Forms;

partial class MainForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        label_Start_Game = new System.Windows.Forms.Label();
        label_Exit = new System.Windows.Forms.Label();
        label_About = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // label_Start_Game
        // 
        label_Start_Game.BackColor = System.Drawing.SystemColors.MenuHighlight;
        label_Start_Game.Font = new System.Drawing.Font("Segoe UI", 25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)204));
        label_Start_Game.Location = new System.Drawing.Point(65, 265);
        label_Start_Game.Name = "label_Start_Game";
        label_Start_Game.Size = new System.Drawing.Size(338, 82);
        label_Start_Game.TabIndex = 0;
        label_Start_Game.Text = "Начать игру";
        label_Start_Game.Click += label_Start_Game_Click;
        // 
        // label_Exit
        // 
        label_Exit.BackColor = System.Drawing.SystemColors.MenuHighlight;
        label_Exit.Font = new System.Drawing.Font("Segoe UI", 25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)204));
        label_Exit.Location = new System.Drawing.Point(436, 265);
        label_Exit.Name = "label_Exit";
        label_Exit.Size = new System.Drawing.Size(338, 82);
        label_Exit.TabIndex = 1;
        label_Exit.Text = "Выйти";
        label_Exit.Click += label_Exit_Click;
        // 
        // label_About
        // 
        label_About.BackColor = System.Drawing.SystemColors.MenuHighlight;
        label_About.Font = new System.Drawing.Font("Segoe UI", 25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)204));
        label_About.Location = new System.Drawing.Point(436, 369);
        label_About.Name = "label_About";
        label_About.Size = new System.Drawing.Size(338, 82);
        label_About.TabIndex = 2;
        label_About.Text = "О приложении";
        label_About.Click += label_About_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackgroundImage = ((System.Drawing.Image)resources.GetObject("$this.BackgroundImage"));
        ClientSize = new System.Drawing.Size(841, 472);
        Controls.Add(label_About);
        Controls.Add(label_Exit);
        Controls.Add(label_Start_Game);
        Text = "Игра \"Кто хочет стать миллионером\"";
        Load += MainForm_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label_About;

    private System.Windows.Forms.Label label_Exit;

    private System.Windows.Forms.Label label_Start_Game;

    #endregion
}