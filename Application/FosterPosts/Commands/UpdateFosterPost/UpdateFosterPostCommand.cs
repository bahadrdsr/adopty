using System;
using Domain.Enums;
using MediatR;

namespace Application.FosterPosts.Commands.UpdateFosterPost
{
    public class UpdateFosterPostCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public Guid SpeciesId { get; set; }
        public Guid FosterProfileId { get; set; }
        public Gender Gender { get; set; }
        public FosterPostStatus Status { get; set; }
    }
}