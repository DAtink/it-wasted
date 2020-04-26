using ItWasted.Day.Api.Features.AddNewWaste.Dto;
using ItWasted.Day.Api.Features.AddNewWaste.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ItWasted.Day.Api.Features.AddNewWaste
{
  [Route("api/[controller]")]
  public class WastesController : ControllerBase
  {
    private readonly IAddNewWasteService _addNewWasteService;

    public WastesController(IAddNewWasteService addNewWasteService)
    {
      _addNewWasteService = addNewWasteService ?? throw new ArgumentNullException(nameof(addNewWasteService));
    }

    [HttpPost("")]
    public async Task<IActionResult> Post([FromBody]WasteDto waste)
    {
      await _addNewWasteService.AddNew(waste).ConfigureAwait(false);
      return Ok();
    }
  }
}
