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
                new CityDto(){Id= 1, Name="Bamenda", Description = "Homeland"},
                new CityDto(){Id= 2, Name="Buea", Description = "South WEst"},
                new CityDto(){Id= 3, Name="Lime", Description = "the land of nice beach"},
                new CityDto(){Id= 4, Name="Douala", Description = "Economic capital of Cameroon"}
            };
            
        }
    }
}
