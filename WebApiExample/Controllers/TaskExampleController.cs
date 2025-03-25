using Microsoft.AspNetCore.Mvc;
using WebApiExample.Services;

namespace WebApiExample.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskExampleController (ITaskExampleService taskExampleService) : ControllerBase
{
    [HttpGet]
    [Route("ValueTaskExample/{id}")]
    public async Task<string> GetValueFromCacheAsync(int id)
    {
        return await taskExampleService.GetValueWithValueTaskFromCacheAsync(id);
    }
}