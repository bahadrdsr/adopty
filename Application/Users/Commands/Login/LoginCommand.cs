using Application.Common.Dtos;
using MediatR;

namespace Application.Users.Commands.Login
{
    public class LoginCommand : IRequest<CurrentUserDto>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}