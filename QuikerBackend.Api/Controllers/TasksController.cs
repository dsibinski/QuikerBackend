using Microsoft.AspNetCore.Mvc;
using QuikerBackend.Api.Models;

namespace QuikerBackend.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TasksController : ControllerBase
{
    private static TodoTask[] TestTasks =>
        new[]
        {
            new TodoTask(Guid.NewGuid(), "Write some code", DateTime.UtcNow.AddDays(2)),
            new TodoTask(Guid.NewGuid(), "Set up GitHub", DateTime.UtcNow.AddDays(4)),
            new TodoTask(Guid.NewGuid(), "Call mum for birthday", DateTime.UtcNow.AddDays(12)),
            new TodoTask(Guid.NewGuid(), "Top up your mobile", DateTime.UtcNow),
            new TodoTask(Guid.NewGuid(), "Finish this project :)", DateTime.UtcNow.AddDays(14)),
            new TodoTask(Guid.NewGuid(), "Create some real data here!", DateTime.UtcNow.AddDays(22))
        };

    [HttpGet(nameof(All))]
    public IEnumerable<TodoTask> All()
    {
        return TestTasks.ToArray();
    }
}
