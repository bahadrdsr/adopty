using Application.Common.Mappings;
using Domain.Entities;

namespace Application.Common.Dtos
{
    public class CandidateProfileDto : IMapFrom<CandidateProfile>
    {
         public void Mapping(AutoMapper.Profile profile)
        {
            profile.CreateMap<CandidateProfile, CandidateProfileDto>();
        }
    }
}