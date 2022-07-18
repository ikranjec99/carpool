
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Carpool.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Carpool.Application.Cities.Queries
{
    public class GetSearchedCitiesQuery : IRequest<IList<CityDto>>
    {
        public string SearchQuery { get; set; }

        public GetSearchedCitiesQuery(string searchQuery)
        {
            SearchQuery = searchQuery;
        }
    }

    public class GetSearchedCitiesQueryHandler : IRequestHandler<GetSearchedCitiesQuery, IList<CityDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetSearchedCitiesQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IList<CityDto>> Handle(GetSearchedCitiesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Cities
                .Include(x => x.County)
                .Where(x => x.Name.Contains(request.SearchQuery))
                .ProjectTo<CityDto>(_mapper.ConfigurationProvider)
                .Take(10)
                .ToListAsync(cancellationToken);
        }
    }
}
