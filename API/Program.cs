using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(); //ASPNet 
builder.Services.AddDbContext<DataContext>(opt => //ASPNet 
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")); //ASPNet 
});

var app = builder.Build(); //ASPNet 

// Configure the HTTP request pipeline.
app.MapControllers(); //ASPNet 

app.Run(); //ASPNet 
