using System.Threading;
using Application.Common.Dtos;
using Application.Common.ViewModels;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.AnimalSpecies.Queries.GetAllAnimalSpecies
{
    public class GetAllAnimalSpeciesQueryHandler : IRequestHandler<GetAllAnimalSpeciesQuery, AnimalSpeciesVm>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public GetAllAnimalSpeciesQueryHandler(DataContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
        public async System.Threading.Tasks.Task<AnimalSpeciesVm> Handle(GetAllAnimalSpeciesQuery request, CancellationToken cancellationToken)
        {
            var data = await _context.AnimalSpecieDbSet.ProjectTo<AnimalSpecieDto>(_mapper.ConfigurationProvider).ToListAsync();
            var vm = new AnimalSpeciesVm
            {
                Data = data,
                Count = data.Count
            };
            return vm;
        }
    }
}