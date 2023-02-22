var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

int nextId = 0;
List<Task> todos = new List<Task>();
todos.Add(new Task(nextId++, "Husk at handle", false));
todos.Add(new Task(nextId++, "Husk at betale skat", false));
todos.Add(new Task(nextId++, "Husk at gøre rent", false));

app.MapGet("/api/tasks", () => todos.ToArray());

app.MapPost("/api/tasks", (Task task) =>
{
    Task newTask = new Task(nextId++, task.text, task.done);
    todos.Add(newTask);
    return newTask;
});

app.Run();

record Task(int id, string text, bool done);
