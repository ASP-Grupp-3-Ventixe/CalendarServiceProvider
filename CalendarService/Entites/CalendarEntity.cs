using System.ComponentModel.DataAnnotations;

namespace CalendarService.Entites;

public class CalendarEntity
{
    [Key]
    public int Id { get; set; }
    public string? Title { get; set; }
    public DateTime StartTime { get; set; }
    public bool IsAllDay { get; set; }
    public string? Location { get; set; }
    public string? Category { get; set; }
    public string? Status { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }
}
