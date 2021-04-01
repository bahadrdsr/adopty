using Application.Common.Dtos;
using MediatR;

namespace Application.CandidatePreferences.Queries.GetCandidateProfile
{
    public class GetCandidateProfileQuery : IRequest<CandidateProfileDto>
    {
        public string AppUserId { get; set; }
    }
}