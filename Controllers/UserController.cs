using Microsoft.AspNetCore.Mvc;

namespace api_dotnet.Controllers;

[ApiController]
[Route("[controller]")]
public class User : ControllerBase
{
    private readonly ILogger<User> _logger;
    public User(ILogger<User> logger)
        => _logger = logger;

    [HttpGet, Route("user")]
    public object Get()
    {
        return new 
        {
            name = "Enzo",
            email = "casamasso@gmail.com"
        };
    }
}
