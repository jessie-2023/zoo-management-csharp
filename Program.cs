using System.Text.Json.Serialization;
using ZooManagement;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(options => 
{ // ignore recursive injections in relational tables
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; 
});

builder.Services.AddDbContext<Zoo>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

