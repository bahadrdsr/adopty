using Application.Common.Dtos;
using MediatR;

namespace Application.Users.Queries.GetCurrentUser
{
    public class GetCurrentUserQuery : IRequest<CurrentUserDto>
    {

    }
}