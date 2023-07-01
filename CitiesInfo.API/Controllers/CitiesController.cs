using CitiesInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CitiesInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        private readonly CitiesDataStore _citiesDataStore;

        public CitiesController(CitiesDataStore citiesDataStore)
        {
            this._citiesDataStore = citiesDataStore;
        }
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(_citiesDataStore.Cities);
        }
        [HttpGet("{id}")]
        public JsonResult GetCity(int id)
        {
            return new JsonResult(_citiesDataStore.Cities.FirstOrDefault(c => c.Id ==id));
        }
    }
}
