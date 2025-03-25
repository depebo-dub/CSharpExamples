using Microsoft.AspNetCore.Mvc;
using WebApiExample.Services;

namespace WebApiExample.Controllers;

[ApiController]
[Route("[controller]")]
public class OopExampleController (ITaskExampleService taskExampleService) : ControllerBase
{
    [HttpGet]
    public async Task<string> GetValueFromCacheAsync(int id)
    {
        return await taskExampleService.GetValueWithValueTaskFromCacheAsync(id);
    }
}