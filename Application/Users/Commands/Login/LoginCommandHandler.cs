using System.Linq;
using System.Threading;
using Application.Common.Dtos;
using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.Users.Commands.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, CurrentUserDto>
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IJwtGenerator _jwtGenerator;
        public LoginCommandHandler(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IJwtGenerator jwtGenerator)
        {
            _jwtGenerator = jwtGenerator;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async System.Threading.Tasks.Task<CurrentUserDto> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user == null)
                throw new NotFoundException(nameof(AppUser), request.Email);

            var result = await _signInManager
                .CheckPasswordSignInAsync(user, request.Password, false);

            if (result.Succeeded)
            {
                var roles = await _userManager.GetRolesAsync(user);
                // TODO: generate token
                var dto = new CurrentUserDto
                {
                    Token = _jwtGenerator.CreateToken(user),
                    Username = user.UserName,
                };
                foreach (string r in roles)
                    dto.Roles.Add(r);
                return dto;
            }

            throw new UnAuthorizedException(request.Email);
        }
    }
}