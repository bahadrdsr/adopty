using System.Threading.Tasks;
using Application.FosterPosts.Commands.AddFosterPostAsset;
using Application.FosterPosts.Commands.CreateFosterPost;
using Application.FosterPosts.Commands.RemoveFosterPostAsset;
using Application.FosterPosts.Commands.UpdateFosterPost;
using Application.FosterPosts.Queries.GetRecommendedPosts;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class FosterPostController : BaseController
    {

        [HttpGet]
        [Route("getrecommended")]
        public async Task<IActionResult> GetRecommendedPosts()
        {
            var result = await Mediator.Send(new GetRecommendedPostsQuery());
            return Ok(result);
        }
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateFosterPost([FromBody] CreateFosterPostCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
        [HttpPost]
        [Route("addasset")]
        public async Task<IActionResult> AddAsset([FromBody] AddFosterPostAssetCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
        [HttpDelete]
        [Route("removeasset")]
        public async Task<IActionResult> RemoveAsset([FromBody] RemoveFosterPostAssetCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateFosterPost([FromBody] UpdateFosterPostCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}