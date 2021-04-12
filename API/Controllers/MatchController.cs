using System.Threading.Tasks;
using Application.Matches.Commands.CreateMatch;
using Application.Matches.Commands.DeleteMatch;
using Application.Matches.Queries.GetMatches;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class MatchController : BaseController
    {

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateMatch([FromBody] CreateMatchCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteMatch([FromBody] DeleteMatchCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> GetMatches()
        {
            var result = await Mediator.Send(new GetMatchesQuery());
            return Ok(result);
        }
    }
}