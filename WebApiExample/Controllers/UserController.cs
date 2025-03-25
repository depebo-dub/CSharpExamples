using Microsoft.AspNetCore.Mvc;
using WebApiExample.Services;

namespace WebApiExample.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController (IUserService userService) : ControllerBase
{
    [HttpGet]
    public IActionResult GetUser(int id)
    {
        return Ok(userService.GetUserName(id));
    }

    [HttpGet("file")]
    public async Task<IActionResult> GetFirstLine()
    {
        try 
        {
            var result = await userService.GetFirstStringFromFileAsync();
            return Ok(result);
        }
        catch (FileNotFoundException)
        {
            return NotFound("Файл не найден: Files\\File.txt");
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Ошибка при чтении файла");
        }
    }
}