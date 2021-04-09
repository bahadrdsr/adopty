using Application.Common.ViewModels;
using MediatR;

namespace Application.FosterPosts.Queries.GetRecommendedPosts
{
    public class GetRecommendedPostsQuery : IRequest<RecommendedPostsVm>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}