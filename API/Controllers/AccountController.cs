using System.Threading.Tasks;
using Application.Users.Commands.Login;
using Application.Users.Commands.Register;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : BaseController
    {
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginCommand command)
        {
            var currentUser = await Mediator.Send(command);
            return Ok(currentUser);
        }
        [HttpPost]
        [Route("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterCommand command)
        {
            var currentUser = await Mediator.Send(command);
            return Ok(currentUser);
        }
    }
}