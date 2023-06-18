namespace CitiesInfo.API.Models
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get;  } = new CitiesDataStore();
        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id= 1, 
                    Name="Bamenda", 
                    Description = "Homeland",
                    PointsOfInterest= new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id= 1,
                            Name="Nkwen",
                            Description = "The main street"
                        },
                        new PointOfInterestDto()
                        {
                            Id= 2,
                            Name="Up Station",
                            Description = "The yaounde of bamenda"
                        },
                        new PointOfInterestDto()
                        {
                            Id= 3,
                            Name="Bambili",
                            Description = "The University of Bambili"
                        }
                    }
                },
                new CityDto()
                {
                    Id= 2,
                    Name="Buea",
                    Description = "South West",
                    PointsOfInterest= new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id= 1,
                            Name="Moya",
                            Description = "The main street in Buea"
                        },
                        new PointOfInterestDto()
                        {
                            Id= 2,
                            Name="Up Station of Buea",
                            Description = "The yaounde of Buea"
                        }
                    }
                },
                new CityDto()
                {
                    Id= 3,
                    Name="Douala",
                    Description = "The economic capital of Cameroon",
                    PointsOfInterest= new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id= 1,
                            Name="Bonaberi",
                            Description = "The main street in Douala"
                        },
                        new PointOfInterestDto()
                        {
                            Id= 2,
                            Name="Up Station of Douala",
                            Description = "The yaounde of Douala"
                        }
                    }
                }
            };
            
        }
    }
}
