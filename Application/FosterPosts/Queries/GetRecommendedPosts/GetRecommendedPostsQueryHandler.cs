using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Common.ViewModels;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.FosterPosts.Queries.GetRecommendedPosts
{
    public class GetRecommendedPostsQueryHandler : IRequestHandler<GetRecommendedPostsQuery, RecommendedPostsVm>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IUserAccessor _userAccessor;

        public GetRecommendedPostsQueryHandler(DataContext context, IMapper mapper, IUserAccessor userAccessor)
        {
            this._context = context;
            this._mapper = mapper;
            this._userAccessor = userAccessor;
        }
        public async Task<RecommendedPostsVm> Handle(GetRecommendedPostsQuery request, CancellationToken cancellationToken)
        {
            var profile = await _context.CandidateProfileDbSet.Where(x => x.AppUserId == _userAccessor.UserId).FirstOrDefaultAsync();
            var candidatePref = profile.CandidatePreference;

            var query = _context.FosterPostDbSet
            .Where(
                x =>
                x.FriendlyWithPeople == candidatePref.FriendlyWithPeople
                && x.FriendlyWithPets == candidatePref.FriendlyWithPets
            );
            if (candidatePref.MaxWeight != null)
            {
                query.Where(
                                x =>
                                x.Weight <= candidatePref.MaxWeight
                            );
            }
            if (candidatePref.MinWeight != null)
            {
                query.Where(
                                x =>
                                x.Weight >= candidatePref.MinWeight
                            );
            }
            if (candidatePref.MinAge != null)
            {
                query.Where(
                                x =>
                                x.Age >= candidatePref.MinAge
                            );
            }
            if (candidatePref.MaxAge != null)
            {
                query.Where(
                                x =>
                                x.Age <= candidatePref.MaxAge
                            );
            }
            if (candidatePref.SpeciesId != null)
            {
                query.Where(
                              x =>
                              x.SpeciesId == candidatePref.SpeciesId
                          );
            }

            var data = await query.Skip(request.PageNumber - 1).Take(request.PageSize).ToListAsync();
            var vm = new RecommendedPostsVm
            {
                Posts = data,
                ShowCount = request.PageSize
            };
            return vm;
            // .Skip(request.PageNumber - 1).Take(request.PageSize).ToListAsync();
        }
    }
}