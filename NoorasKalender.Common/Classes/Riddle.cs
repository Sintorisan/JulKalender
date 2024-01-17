using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoorasKalender.Common.Classes;

public class Riddle
{
    public int Id { get; set; }
    public string Question { get; set; } = string.Empty;
    public string UserAnswer { get; set; } = string.Empty;
    public int AnswersId { get; set; }

    [ForeignKey("AnswersId")]
    public AnswersOptions? Answers { get; set; }
    public bool RightOrFalse => Answers?.CheckAnswer(UserAnswer) ?? false;

    public Riddle() { }
}

