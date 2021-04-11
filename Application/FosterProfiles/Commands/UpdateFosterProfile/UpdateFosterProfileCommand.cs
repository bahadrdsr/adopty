using System;
using MediatR;

namespace Application.FosterProfiles.Commands.UpdateFosterProfile
{
    public class UpdateFosterProfileCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public string Info { get; set; }
    }
}