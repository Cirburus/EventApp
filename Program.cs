using EventsApp.Models;
using EventsApp.Services;
using EventsApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

//This is the builder that will build everything
//args contains the appSettings.json in builder.Configuration[""]
var builder = WebApplication.CreateBuilder(args);

//This is telling the builder what to build
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddDbContext<SnowflakeContext>(options => options.UseSnowflake(builder.Configuration["Snowflake"]));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//This is the builder building what it was told to build
var app = builder.Build();

//"middleware" layers 
app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

await app.RunAsync();