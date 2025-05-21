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
            Title = dto.Title,
            StartTime = dto.StartTime,
            EndTime = dto.EndTime,
            IsAllDay = dto.IsAllDay,
        };
    }

}
