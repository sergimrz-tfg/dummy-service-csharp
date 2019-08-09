using Microsoft.AspNetCore.Mvc;

[Route("api/")]
[ApiController]
public class ApiController : ControllerBase
{
    public const string VERSION = "1.0";

    // GET: api/
    [HttpGet("version")]
    public ActionResult<string> Get(string value)
    {
        return  "You are running the version "+ VERSION;
    }
}
