using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models;

public class Session
{
    public int Id { get; set; }
    [Display(Name = "Game Title")]
    [StringLength(60, MinimumLength = 1)]
    [Required]
    public string? GameTitle { get; set; }
    [DataType(DataType.Date)]
    public DateTime Date { get; set; }
    [Display(Name = "Start Time")]
    public TimeOnly StartTime {get; set;}
    [Display(Name = "End Time")]
    public TimeOnly EndTime {get; set;}
    public int Wins { get; set; }
    public int Losses{get; set;}
    [Display(Name = "Rank Change")]
    [StringLength(60, MinimumLength = 3)]
    public string? RankChange { get; set; }
}