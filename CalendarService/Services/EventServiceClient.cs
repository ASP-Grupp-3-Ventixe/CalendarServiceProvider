using CalendarService.Dtos;

namespace CalendarService.Services
{
    public class EventServiceClient : IEventServiceClient
    {
        private readonly HttpClient _httpClient;

        public EventServiceClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<EventDto>> GetAllEventsAsync()
        {
            try
            {
                var events = await _httpClient.GetFromJsonAsync<List<EventDto>>("api/events");
                return events ?? new List<EventDto>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<EventDto>();
            }

        }
    }
}
