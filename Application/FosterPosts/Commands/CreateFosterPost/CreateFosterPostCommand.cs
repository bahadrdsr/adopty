using System;
using Domain.Entities;
using Domain.Enums;
using MediatR;

namespace Application.FosterPosts.Commands.CreateFosterPost
{
    public class CreateFosterPostCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public Guid SpeciesId { get; set; }
        public Guid FosterProfileId { get; set; }
        public Gender Gender { get; set; }
        public FosterPostStatus Status { get; set; }

    }
}