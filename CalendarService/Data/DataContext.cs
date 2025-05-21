using CalendarService.Entites;
using Microsoft.EntityFrameworkCore;

namespace CalendarService.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{

    public DbSet<CalendarEntity> CalendarEvents { get; set; }
}
