using Application.Common.Dtos;
using MediatR;

namespace Application.Users.Queries.GetAllUsers
{
    public class GetAllUsersQuery : IRequest<UserListVm>
    {
        public int PageNo { get; set; }
        public int PageSize { get; set; }
    }
}