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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<City>().HasData(
                new City("Bamenda")
                {
                    Id=1,
                    Description="Homeland"
                },
                new City("Buea")
                {
                    Id = 2,
                    Description = "South West"
                },
                new City("Douala")
                {
                    Id = 3,
                    Description = "The Economic Capital"
                });

            builder.Entity<PointOfInterest>().HasData(
                new PointOfInterest("Nkwen")
                {
                    Id=1,
                    CityId = 1,
                    Description="The Main street"
                },
                new PointOfInterest("UpStation")
                {
                    Id = 2,
                    CityId = 1,
                    Description = "The Yaounde of Bamenda"
                },
                new PointOfInterest("Bambili")
                {
                    Id = 3,
                    CityId = 1,
                    Description = "The University of Bambili"
                },
                new PointOfInterest("Moya")
                {
                    Id = 4,
                    CityId = 2,
                    Description = "The central town of Buea"
                },
                new PointOfInterest("Molyko")
                {
                    Id = 5,
                    CityId = 2,
                    Description = "The Yaounde of Buea"
                },
                new PointOfInterest("UpStation")
                {
                    Id = 6,
                    CityId = 2,
                    Description = "The market"
                },
                 new PointOfInterest("Bonas")
                 {
                     Id = 7,
                     CityId = 3,
                     Description = "The sea port"
                 },
                  new PointOfInterest("Bonamosadi")
                  {
                      Id = 8,
                      CityId = 3,
                      Description = "The police headquarters"
                  },
                   new PointOfInterest("Bonaberi")
                   {
                       Id = 9,
                       CityId = 3,
                       Description = "The Anglophone area of douala"
                   });

            base.OnModelCreating(builder);
        }
    }
}
