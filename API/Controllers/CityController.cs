using System.Threading.Tasks;
using Application.Cities.Queries.GetAllCities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class CityController : BaseController
    {

        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetCities()
        {
            var result = await Mediator.Send(new GetAllCitiesQuery());
            return Ok(result);
        }
    }
}