using Microsoft.AspNetCore.Mvc;

namespace dotnetexample.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    private readonly IHostEnvironment _hostEnvironment;

    public HomeController(IHostEnvironment hostEnvironment)
    {
        _hostEnvironment = hostEnvironment;
    }

    [HttpGet("[action]")]
    public IActionResult Sample()
    {
        return Ok($"time is : {DateTime.Now.ToLongTimeString()}");
    }

    [HttpGet("[action]")]
    public IActionResult GetEnv()
    {
        return Ok($"environment is : {_hostEnvironment.EnvironmentName}");
    }
}