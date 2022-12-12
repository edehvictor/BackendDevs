namespace API.Controllers;

[ApiController]
[Route("[Example]")]
public class ExampleController : Contro.llerBase
{
    public string Get()
    {
        return "Hello get method is calling!respond";
    }
}

