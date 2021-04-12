using System.Threading.Tasks;
using Application.Conversations.Commands.CreateConversation;
using Application.Conversations.Queries.GetConversationById;
using Application.Conversations.Queries.GetFosterConversations;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class ConverstaionController : BaseController
    {

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> GetConverstaionById([FromBody] GetConversationByIdQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }
        [HttpGet]
        [Route("getcandidate")]
        public async Task<IActionResult> GetCandidateConversations()
        {
            var result = await Mediator.Send(new GetCandidateConversationsQuery());
            return Ok(result);
        }
        [HttpGet]
        [Route("getfoster")]
        public async Task<IActionResult> GetFosterConversations()
        {
            var result = await Mediator.Send(new GetFosterConversationsQuery());
            return Ok(result);
        }
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateConverstaion([FromBody] CreateConversationCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}