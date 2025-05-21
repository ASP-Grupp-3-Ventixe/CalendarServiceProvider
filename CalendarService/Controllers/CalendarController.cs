using CalendarService.Mappers;
using CalendarService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalendarService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarController(EventServiceClient eventServiceClient) : ControllerBase
    {
        private readonly EventServiceClient _eventServiceClient = eventServiceClient;

        [HttpGet]
        public async Task<IActionResult> GetCalendarEvents()
        {
            var eventDtos = await _eventServiceClient.GetAllEventsAsync();
            
            var calendarEntities = eventDtos.Select(EventMapper.MapToCalendarEntity).ToList();
            return Ok(calendarEntities);
        }
    }
}
