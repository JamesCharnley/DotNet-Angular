using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(); //ASPNet 

builder.Services.AddDbContext<DataContext>(opt => //ASPNet 
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")); //ASPNet 
});

builder.Services.AddCors();
builder.Services.AddScoped<ITokenService, TokenService>();

var app = builder.Build(); //ASPNet 

// Configure the HTTP request pipeline.
app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200"));

app.MapControllers(); //ASPNet 

app.Run(); //ASPNet 
