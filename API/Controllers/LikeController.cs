using System.Threading.Tasks;
using Application.Cities.Queries.GetAllCities;
using Application.Likes.Commands.LikeCandidate;
using Application.Likes.Commands.LikePost;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class LikeController : BaseController
    {

        [HttpPost]
        [Route("likepost")]
        public async Task<IActionResult> LikePost([FromBody] LikePostCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
        [HttpPost]
        [Route("likecandidate")]
        public async Task<IActionResult> LikeCandidate([FromBody] LikeCandidateCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}