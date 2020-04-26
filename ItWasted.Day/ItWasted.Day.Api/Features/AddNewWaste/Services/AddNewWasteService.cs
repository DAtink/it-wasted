using ItWasted.Day.Api.Db;
using ItWasted.Day.Api.Features.AddNewWaste.Dto;
using ItWasted.Day.Api.Features.AddNewWaste.Mappers;
using System.Threading.Tasks;

namespace ItWasted.Day.Api.Features.AddNewWaste.Services
{
  internal class AddNewWasteService : IAddNewWasteService
  {
    private readonly ItWastedDbContext _dbContext;

    public AddNewWasteService(ItWastedDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task AddNew(WasteDto newWasteDto)
    {
      var waste = newWasteDto.MapToEntity();
      await _dbContext.AddAsync(waste);
      await _dbContext.SaveChangesAsync().ConfigureAwait(false);
    }
  }
}
