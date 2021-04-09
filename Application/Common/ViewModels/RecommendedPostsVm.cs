using System.Collections.Generic;
using Domain.Entities;

namespace Application.Common.ViewModels
{
    public class RecommendedPostsVm
    {
        public List<FosterPost> Posts { get; set; }
        public int ShowCount { get; set; }
    }
}