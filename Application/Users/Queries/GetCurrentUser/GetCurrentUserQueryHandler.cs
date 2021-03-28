using System.Threading;
using Application.Common.Dtos;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.Users.Queries.GetCurrentUser
{
    public class GetCurrentUserQueryHandler : IRequestHandler<GetCurrentUserQuery, CurrentUserDto>
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IJwtGenerator _jwtGenerator;
        private readonly IUserAccessor _userAccessor;
        public GetCurrentUserQueryHandler(UserManager<AppUser> userManager, IJwtGenerator jwtGenerator, IUserAccessor userAccessor)
        {
            _userAccessor = userAccessor;
            _jwtGenerator = jwtGenerator;
            _userManager = userManager;
        }
        public async System.Threading.Tasks.Task<CurrentUserDto> Handle(GetCurrentUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByNameAsync(_userAccessor.UserId);
            var currentUser = new CurrentUserDto
            {
                Username = user.UserName,
                Token = _jwtGenerator.CreateToken(user),
            };
            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
                currentUser.Roles.Add(role);

            return currentUser;
        }
    }
}