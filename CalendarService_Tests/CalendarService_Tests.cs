using CalendarService.Dtos;
using CalendarService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class EventServiceClientTest : IEventServiceClient
{
    public Task<List<EventDto>> GetAllEventsAsync()
    {
        return Task.FromResult(new List<EventDto>
        {
            new EventDto
            {
                Id = 1,
                Title = "Testevent",
                Date = DateTime.Now,
                Location = "Online"
            }
        });
    }
}

public class EventServiceClientTests
{
    [Fact]
    public async Task GetAllEventsAsync_ShouldReturnListOfEvents()
    {
        // Arrange
        var service = new EventServiceClientTest();

        // Act
        var result = await service.GetAllEventsAsync();

        // Assert
        Assert.NotNull(result);
        Assert.Single(result);
        Assert.Equal("Testevent", result[0].Title);
    }
}

}
