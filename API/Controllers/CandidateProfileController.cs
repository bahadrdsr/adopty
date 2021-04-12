using System.Threading.Tasks;
using Application.CandidateProfiles.Commands;
using Application.CandidateProfiles.Queries.GetCandidateProfile;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class CandidateProfileController : BaseController
    {
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateCandidateProfile([FromBody] CreateCandidateProfileCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }


        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> GetCandidateProfile(string userId)
        {
            var result = await Mediator.Send(new GetCandidateProfileQuery { AppUserId = userId });
            return Ok(result);
        }
    }
}