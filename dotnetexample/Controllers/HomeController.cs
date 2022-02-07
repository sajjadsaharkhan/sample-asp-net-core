using Microsoft.AspNetCore.Mvc;

namespace dotnetexample.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet("[action]")]
    public IActionResult Sample()
    {
        return Ok($"time is : {DateTime.Now.ToLongTimeString()}");
    }
}