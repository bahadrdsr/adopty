using System.Threading.Tasks;
using Application.FosterProfiles.Commands.CreateFosterProfile;
using Application.FosterProfiles.Commands.UpdateFosterProfile;
using Application.FosterProfiles.Queries.GetFosterProfile;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class FosterProfileController : BaseController
    {


        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateFosterProfile([FromBody] CreateFosterProfileCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateFosterProfile([FromBody] UpdateFosterProfileCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> GetFosterProfile()
        {
            var result = await Mediator.Send(new GetFosterProfileQuery());
            return Ok(result);
        }
    }
}