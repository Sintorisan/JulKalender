using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoorasKalender.Common.Classes;

public class Day
{
    public int Id { get; set; }
    public DateOnly DateToOpen => new DateOnly(2023, 12, Id);
    public bool CanOpen => DateToOpen <= DateOnly.FromDateTime(DateTime.UtcNow);
    public int RiddleId { get; set; }
    public Riddle? Riddle { get; set; }
    public string ClosedImageUrl { get; set; } = "Img/ClosedPresent.png";
    public string OpenImageUrl { get; set; } = "Img/OpenPresent.png";
    public string CurrentImageUrl => CanOpen ? OpenImageUrl : ClosedImageUrl;
    public Day() { }
}
