using CalendarService.Dtos;

namespace CalendarService.Services
{
    public interface IEventServiceClient
    {
        Task<List<EventDto>> GetAllEventsAsync();
    }
}