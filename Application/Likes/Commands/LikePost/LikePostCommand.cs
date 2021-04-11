using System;
using MediatR;

namespace Application.Likes.Commands.LikePost
{
    public class LikePostCommand : IRequest
    {
        public Guid PostId { get; set; }


    }
}