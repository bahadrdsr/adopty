using System.Threading.Tasks;
using Application.Countries.Queries.GetAllCountries;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class CountryController : BaseController
    {

        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetCountries()
        {
            var result = await Mediator.Send(new GetAllCountriesQuery());
            return Ok(result);
        }
    }
}