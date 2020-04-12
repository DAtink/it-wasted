using ItWasted.Day.Api.Features.AddWasted.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ItWasted.Day.Api.Features.AddWasted
{
  [Route("api/[controller]")]
  public class WastesController : ControllerBase
  {
    [HttpPost("")]
    public IActionResult Post([FromBody]WastesPackDto wastesPack)
    {
      return Ok();
    }
  }
}
