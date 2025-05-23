using CalendarService.Dtos;

namespace CalendarService.Services
{
    using System.Text.Json;

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
                var response = await _httpClient.GetAsync("api/events");

                if (!response.IsSuccessStatusCode)
                {
                    return new List<EventDto>();
                }

                var json = await response.Content.ReadAsStringAsync();

                var events = JsonSerializer.Deserialize<List<EventDto>>(json);

                return events ?? new List<EventDto>();
            }
            catch (Exception ex)
            {
                return new List<EventDto>();
            }
        }
    }

}
