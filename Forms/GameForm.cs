using MillionaireGame.Services;

namespace MillionaireGame.Forms;

public partial class GameForm : Form
{
    public GameForm()
    {
        InitializeComponent();
    }

    private void GameForm_Load(object sender, EventArgs e)
    {
        var questions = QuestionService.GetQuestions();
        var question = questions.FirstOrDefault();
        textBox_Answer.Text = question.Text;
    }
}