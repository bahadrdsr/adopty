using Application.Common.ViewModels;
using MediatR;

namespace Application.AnimalSpecies.Queries.GetAllAnimalSpecies
{
    public class GetAllAnimalSpeciesQuery : IRequest<AnimalSpeciesVm>
    {
        // public int PageNo { get; set; }
        // public int PageSize { get; set; }
    }
}