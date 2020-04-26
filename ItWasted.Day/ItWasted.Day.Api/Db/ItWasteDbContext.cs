using ItWasted.Day.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ItWasted.Day.Api.Db
{
  internal class ItWastedDbContext : DbContext
  {
    public ItWastedDbContext(DbContextOptions<ItWastedDbContext> options) : base(options) { }

    public DbSet<Waste> Wastes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Waste>().ToTable("Wastes").HasKey(x => x.Id);
    }
  }
}
