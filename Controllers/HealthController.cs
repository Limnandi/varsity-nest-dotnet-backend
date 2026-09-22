using Microsoft.AspNetCore.Mvc;

namespace varsity_nest_dotnet_backend.Controllers;

// [ApiController] tells ASP.NET Core that this class handles HTTP API requests.
// It also enables useful API behavior such as automatic request validation.
[ApiController]

// [Route] defines the URL that will point to this controller.
// Because this says "api/health", our endpoint starts at:
// http://localhost:7034/api/health
[Route("api/health")]
public class HealthController : ControllerBase
{
    // [HttpGet] tells ASP.NET Core that this method should respond
    // when someone sends a GET request to /api/health.
    //
    // GET is normally used when we want to retrieve information.
    [HttpGet]
    public IActionResult Get()
    {
        // Ok() creates an HTTP 200 response.
        //
        // The object inside Ok() is automatically converted to JSON
        // by ASP.NET Core before being sent back to the client.
        return Ok(new
        {
            // This follows the response format used by the
            // original Varsity Nest backend.
            success = true,

            // This is the message that the client receives.
            message = "Varsity Nest API is running"
        });
    }
}