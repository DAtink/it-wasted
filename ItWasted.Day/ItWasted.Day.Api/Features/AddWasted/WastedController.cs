using Microsoft.AspNetCore.Mvc;

namespace ItWasted.Day.Api.Features.AddWasted
{
  [Route("api/[controller]")]
  public class WastedController: ControllerBase
  {
    [HttpGet("")]
    public IActionResult Get()
    {
      return Ok();
    }
  }
}
