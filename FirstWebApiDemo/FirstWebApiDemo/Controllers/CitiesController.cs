using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        List<string> cityList = null;
        public CitiesController()
        {
            if(cityList == null)
            {
                cityList = new List<string>() 
                { 
                    "Delhi",
                    "Lucknow",
                    "Kolkata",
                    "Mumbai",
                    "Rameshpuram",
                    "Jaipur",
                    "Raipur",
                    "Kota"
                };
            }

        }
        [Route("JoiningCities")]
        [HttpGet]
        public List<string> ShowAllCities()
        {
            return new List<string>(cityList);
        }

    }
}
