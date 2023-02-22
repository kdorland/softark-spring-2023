var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Task[] todos = new Task[] {
    new Task(0, "Husk at handle", false),
    new Task(1, "Husk at betale skat", false),
    new Task(2, "Husk at gøre rent", false),
};

app.MapGet("/api/tasks", () => "???");

app.Run();

record Task(int id, string text, bool done);
