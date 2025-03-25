using Microsoft.AspNetCore.Mvc;
using WebApiExample.Services;

namespace WebApiExample.Controllers;

[ApiController]
[Route("[controller]")]
public class OopExampleController (IOopExampleService oopExampleService) : ControllerBase
{
    [HttpGet]
    public string OverrideDemo()
    {
         oopExampleService.DifferenceOverrideAndNewDemo();
         return "This method only for debugging OverrideDemo method";
    }
}