using System;
using Application.Common.Dtos;
using MediatR;

namespace Application.Users.Commands.Register
{
    public class RegisterCommand : IRequest<CurrentUserDto>
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
    }
}