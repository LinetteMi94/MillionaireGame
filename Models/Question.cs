namespace MillionaireGame.Models;

public class Question
{
    public string Text { get; set; }
    public int Level { get; set; }
    public List<Answer> Answers { get; set; }
    
}