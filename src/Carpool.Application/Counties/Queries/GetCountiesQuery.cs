using AutoMapper;
using AutoMapper.QueryableExtensions;
using Carpool.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Carpool.Application.Counties.Queries
{
    public class GetCountiesQuery : IRequest<IList<CountyDto>>
    {
        
    }

    public class GetCountiesQueryHandler : IRequestHandler<GetCountiesQuery, IList<CountyDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetCountiesQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IList<CountyDto>> Handle(GetCountiesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Counties
                .ProjectTo<CountyDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }

}
