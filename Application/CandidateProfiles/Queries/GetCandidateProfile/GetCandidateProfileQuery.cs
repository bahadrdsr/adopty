using Application.Common.Dtos;
using MediatR;

namespace Application.CandidateProfiles.Queries.GetCandidateProfile
{
    public class GetCandidateProfileQuery : IRequest<CandidateProfileDto>
    {
        public string AppUserId { get; set; }
    }
}