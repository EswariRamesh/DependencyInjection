using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApplication1.DAL;
using WebApplication1.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton<IEmployee, Employee>();
builder.Services.AddSingleton<IWeatherService, WeatherService>();
builder.Services.AddScoped<IWeatherService, WeatherService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseRouting();
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapDefaultControllerRoute();
//});

//app.Run();

//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
