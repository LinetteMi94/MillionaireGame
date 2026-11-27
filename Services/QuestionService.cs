using System.Text.Json;
using MillionaireGame.Models;

namespace MillionaireGame.Services;

public class QuestionService
{
    private const string FileName = "Questions.json";
    
    public static List<Question> GetQuestions()
    {
        if (!File.Exists(FileName)) return [];
        var json = File.ReadAllText(FileName);
        return JsonSerializer.Deserialize<List<Question>>(json) ?? [];
    }
}