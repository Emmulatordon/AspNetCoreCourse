using CitiesInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CitiesInfo.API.DbContexts
{
    public class CityInfoDbContext:DbContext
    {
        public CityInfoDbContext(DbContextOptions<CityInfoDbContext> options):base(options)
        {
            
        }
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<PointOfInterest> PointsOfinterest { get; set; } = null!;
    }
}
