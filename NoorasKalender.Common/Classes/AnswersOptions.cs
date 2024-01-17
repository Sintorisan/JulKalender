using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoorasKalender.Common.Classes;

public class AnswersOptions
{
    public List<string> _answers = new List<string>();

    public int Id { get; set; }
    public string RightAnswer { get; set; } = string.Empty;
    public string UserAnswer { get; set; } = string.Empty;
    public bool RightOrFalse => CheckAnswer(UserAnswer);

    public AnswersOptions(int id, string a1, string a2, string rightAnswer)
    {
        Id = id;
        _answers.Add(a1);
        _answers.Add(a2);
        _answers.Add(rightAnswer);
        RightAnswer = rightAnswer;

        Random rng = new Random();
        _answers = _answers.OrderBy(a => rng.Next()).ToList();
    }
    public AnswersOptions() { }


    public bool CheckAnswer(string answer)
    {
        return answer == RightAnswer;
    }
}
