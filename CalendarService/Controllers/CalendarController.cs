using CalendarService.Mappers;
using CalendarService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalendarService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarController : ControllerBase
    {
        private readonly IEventServiceClient _eventServiceClient;

        public CalendarController(IEventServiceClient eventServiceClient)
        {
            _eventServiceClient = eventServiceClient;
        }

        [HttpGet]
        public async Task<IActionResult> GetCalendarEvents()
        {
            try
            {
                var eventDtos = await _eventServiceClient.GetAllEventsAsync();
                var calendarEntities = eventDtos
                    .Select(EventMapper.MapToCalendarEntity)

                    .ToList();

                return Ok(calendarEntities);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }
    }

}
