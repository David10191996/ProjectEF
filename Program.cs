using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projectEF;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TaskContext>(x => x.UseInMemoryDatabase("TaskDB"));


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconnection", async([FromServices] TaskContext context) =>
{
    context.Database.EnsureCreated();
    //var categories = await context.Categories.ToListAsync();
    return Results.Ok("Base de datos creada" + context.Database.IsInMemory());
});
app.Run();
