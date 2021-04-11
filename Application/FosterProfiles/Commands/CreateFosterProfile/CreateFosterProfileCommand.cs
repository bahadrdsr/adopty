using System;
using MediatR;

namespace Application.FosterProfiles.Commands.CreateFosterProfile
{
    public class CreateFosterProfileCommand : IRequest<Guid>
    {
        public string Info { get; set; }
    }
}