using CalendarService.Services;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// CORS – för att tillåta frontend att anropa API:t
builder.Services.AddCors();

// HttpClient – koppling till din kompis API
builder.Services.AddHttpClient<IEventServiceClient, EventServiceClient>(client =>
{
    client.BaseAddress = new Uri("https://eventservice-rk6f.onrender.com/");
});

// Lägg till controllers
builder.Services.AddControllers();

// Lägg till Swagger/OpenAPI-tjänster
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Calendar API", Version = "v1" });
});

var app = builder.Build();

// Aktivera Swagger och UI
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Calendar API v1");
});

// Aktivera CORS
app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.UseHttpsRedirection();

// Endast om du använder autentisering – annars utelämnas
// app.UseAuthentication();

app.UseAuthorization();

// Route: api/calendar
app.MapControllers();

app.Run();
