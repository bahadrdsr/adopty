using System.Collections.Generic;
using Application.Common.Dtos;
using MediatR;

namespace Application.Matches.Queries.GetMatches
{
    public class GetMatchesQuery : IRequest<List<MatchDto>>
    {

    }
}