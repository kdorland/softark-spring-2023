var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Random tal = new Random();

var array = new string[] { "æbler", "davs", "hello " };


app.MapPost("/api/hello", (Fruit fruit) =>
{
    array = array.Append(fruit.name).ToArray();
});

app.MapGet("/api/hello", () => array);
app.MapGet("/api/hello/{name}", (string name) => 
    new { Message = $"Hello {name}!"});

app.MapGet("/api/randomTal", () => tal.Next(4));

app.Run();

record Fruit(string name);
