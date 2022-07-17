using AutoMapper;
using AutoMapper.QueryableExtensions;
using Carpool.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Carpool.Application.Counties.Queries
{
    public class GetSearchedCountiesQuery : IRequest<IList<CountyDto>> 
    {
        public string SearchQuery { get; set; }

        public GetSearchedCountiesQuery(string searchQuery)
        {
            SearchQuery = searchQuery;
        }
    }

    public class GetSearchedCountiesQueryHandler : IRequestHandler<GetSearchedCountiesQuery, IList<CountyDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetSearchedCountiesQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IList<CountyDto>> Handle(GetSearchedCountiesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Counties
                .Where(x => x.Name.Contains(request.SearchQuery))
                .ProjectTo<CountyDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
