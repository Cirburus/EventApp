using System.Reflection;
using EventsApp.Models;
using EventsApp.Services;
using EventsApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;

//This is the builder that will build everything
//args contains the appSettings.json in builder.Configuration[""]
var builder = WebApplication.CreateBuilder(args);

//This is telling the builder what to build
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddDbContext<SnowflakeContext>(options => options.UseSnowflake(builder.Configuration["Snowflake"]));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Events Api",
        Description = "An API for managing the EventsApp Snowflake Database"
    });
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});


//This is the builder building what it was told to build
var app = builder.Build();

//"middleware" layers 
app.MapControllers();


app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

await app.RunAsync();