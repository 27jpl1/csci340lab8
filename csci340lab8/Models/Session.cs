using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models;

public class Session
{
    public int Id { get; set; }
    public string? GameTitle { get; set; }
    [DataType(DataType.Date)]
    public DateTime Date { get; set; }
    public TimeOnly StartTime {get; set;}
    public TimeOnly EndTime {get; set;}
    public int Wins { get; set; }
    public int Losses{get; set;}
    public string? RankChange { get; set; }
}