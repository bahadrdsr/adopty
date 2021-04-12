using System.Threading.Tasks;
using Application.FosterPreferences.Commands.CreateFosterPreference;
using Application.FosterPreferences.Commands.UpdateFosterPreference;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class FosterPreferenceController : BaseController
    {

      
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateFosterPost([FromBody] CreateFosterPreferenceCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateFosterPost([FromBody] UpdateFosterPreferenceCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}