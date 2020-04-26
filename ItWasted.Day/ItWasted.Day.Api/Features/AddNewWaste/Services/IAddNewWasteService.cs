using ItWasted.Day.Api.Features.AddNewWaste.Dto;
using System.Threading.Tasks;

namespace ItWasted.Day.Api.Features.AddNewWaste.Services
{
  public interface IAddNewWasteService
  {
    public Task AddNew(WasteDto newWasteDto);
  }
}
