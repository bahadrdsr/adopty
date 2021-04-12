using System.Threading.Tasks;
using Application.Users.Commands.CreateUser;
using Application.Users.Commands.DeleteUser;
using Application.Users.Commands.UpdateUser;
using Application.Users.Queries;
using Application.Users.Queries.GetAllUsers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class UsersController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<UserListVm>> GetAll(GetAllUsersQuery query)
        {
            return Ok(await Mediator.Send(query));
        }
        [Authorize]
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create([FromBody] CreateUserCommand command)
        {
            var id = await Mediator.Send(command);
            return Ok();
        }

        [Authorize]
        [HttpPut]
        [HttpPatch]
        [Route("update")]
        public async Task<IActionResult> Update([FromBody] UpdateUserCommand command)
        {
            var id = await Mediator.Send(command);
            return Ok();
        }
        [Authorize]
        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> Delete([FromQuery] string id)
        {
            await Mediator.Send(new DeleteUserCommand { Id = id });
            return NoContent();
        }
    }
}