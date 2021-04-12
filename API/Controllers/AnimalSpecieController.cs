using System.Threading.Tasks;
using Application.AnimalSpecies.Queries.GetAllAnimalSpecies;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class AnimalSpecieController : BaseController
    {
        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAllAnimalSpecies()
        {
            var result = await Mediator.Send(new GetAllAnimalSpeciesQuery());
            return Ok(result);
        }
    }
}