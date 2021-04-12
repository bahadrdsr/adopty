using System.Threading.Tasks;
using Application.CandidatePreferences.Commands.CreateCandidatePreference;
using Application.CandidatePreferences.Commands.UpdateCandidatePreference;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class CandidatePreferenceController : BaseController
    {
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateCandidatePreference([FromBody] CreateCandidatePreferenceCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateCandidatePreference([FromBody] UpdateCandidatePreferenceCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}