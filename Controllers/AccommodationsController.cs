using Microsoft.AspNetCore.Mvc;
using varsity_nest_dotnet_backend.Services;

namespace varsity_nest_dotnet_backend.Controllers;

[ApiController]
[Route("api/accommodations")]
public class AccommodationController : ControllerBase
{
    private readonly AccommodationService _accommodationService;

    public AccommodationController(AccommodationService accommodationService)
    {
        _accommodationService = accommodationService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var accommodations = _accommodationService.GetAll();

        return Ok(new
        {
            success = true,
            data = accommodations
        });
    }
}