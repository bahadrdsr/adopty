using System;
using MediatR;

namespace Application.Matches.Commands.DeleteMatch
{
    public class DeleteMatchCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}