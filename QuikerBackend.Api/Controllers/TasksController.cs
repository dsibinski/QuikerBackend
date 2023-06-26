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
            new TodoTask(Guid.Parse("9fee8375-3442-4d2c-8dd3-e13a93d79fe9"), "Write some code", DateTime.UtcNow.AddDays(2)),
            new TodoTask(Guid.Parse("88320e2f-04cc-479d-be79-3ac2d739b46e"), "Set up GitHub", DateTime.UtcNow.AddDays(4)),
            new TodoTask(Guid.Parse("da4e417c-bd2e-4aa7-88ac-28eb69573d1e"), "Call mum for birthday", DateTime.UtcNow.AddDays(12)),
            new TodoTask(Guid.Parse("44c51ca1-9cef-485d-b4e3-3f18729ffb16"), "Top up your mobile", DateTime.UtcNow),
            new TodoTask(Guid.Parse("dfbe37f5-3a1d-477e-850f-7a5a5ed47222"), "Finish this project :)", DateTime.UtcNow.AddDays(14)),
            new TodoTask(Guid.Parse("69a5a042-2469-4b17-b0ed-370cf8963bd2"), "Create some real data here!", DateTime.UtcNow.AddDays(22))
        };

    [HttpGet(nameof(All))]
    public IEnumerable<TodoTask> All()
    {
        return TestTasks.ToArray();
    }

    [HttpGet(nameof(Details) + "/{id}")]
    public TodoTask Details(Guid id)
    {
        var task = TestTasks.SingleOrDefault(t => t.Id == id);
        return task;
    }
}
