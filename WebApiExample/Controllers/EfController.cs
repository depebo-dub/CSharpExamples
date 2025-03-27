using Microsoft.AspNetCore.Mvc;
using WebApiExample.Services;

namespace WebApiExample.Controllers;

[ApiController]
[Route("[controller]")]
public class EfController (IEfService efService) : ControllerBase
{
    [HttpGet]
    public IActionResult GetUserById(int id)
    {
        return Ok(efService.GetUserById(id));
    }
}