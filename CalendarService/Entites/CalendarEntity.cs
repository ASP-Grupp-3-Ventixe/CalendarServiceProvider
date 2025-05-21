using System.ComponentModel.DataAnnotations;

namespace CalendarService.Entites;

public class CalendarEntity
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    public string Title { get; set; }

    [Required]
    public DateTime StartTime { get; set; }

    [Required]
    public DateTime EndTime { get; set; }

    public bool IsAllDay { get; set; }
}
