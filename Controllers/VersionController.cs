using Microsoft.AspNetCore.Mvc;

[Route("/")]
[ApiController]
public class VersionController : ControllerBase
{
    public static Version version = new Version();

    [HttpGet("version")]
    public ActionResult<string> getVersion()
    {
        return version.getVersion();
    }

    [HttpGet("upgrade")]
    public ActionResult<string> upgradeVersion()
    {
        return version.upgradeVersion();
    }
}
