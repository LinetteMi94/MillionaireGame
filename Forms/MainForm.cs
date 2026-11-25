namespace MillionaireGame.Forms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        BackColor = Color.MediumVioletRed;
    }

    private void label_Start_Game_Click(object sender, EventArgs e)
    {
        var gameForm = new GameForm();
        gameForm.Show();
        Hide();
    }

    private void label_Exit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void label_About_Click(object sender, EventArgs e)
    {
        var aboutForm = new AboutForm();
        aboutForm.Show();
    }
}