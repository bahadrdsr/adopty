using System.Threading.Tasks;
using Application.Messages.Commands.SendMessage;
using Application.Messages.Queries.GetMessages;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class MessageController : BaseController
    {

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> SendMessage([FromBody] SendMessageCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> GetMessages([FromBody] GetMessagesQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }
    }
}