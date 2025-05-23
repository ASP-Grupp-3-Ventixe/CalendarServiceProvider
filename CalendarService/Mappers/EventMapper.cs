using CalendarService.Dtos;
using CalendarService.Entites;

namespace CalendarService.Mappers;

public static class EventMapper
{
    public static CalendarEntity MapToCalendarEntity(EventDto dto)
    {
        return new CalendarEntity
        {
            Id = dto.Id,
            Title = dto.Title ?? "Unknown Event",
            StartTime = dto.Date,
            IsAllDay = false,
            Location = dto.Location ?? "Unknown Location",
            Category = dto.Category ?? "Unknown Category",
            Status = dto.Status ?? "Unknown Status",
            Description = dto.Description ?? "No Details",
            Price = dto.Price
        };
    }
}
