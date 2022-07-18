using AutoMapper;
using AutoMapper.QueryableExtensions;
using Carpool.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Carpool.Application.Cars.Queries
{
    public class GetCarsQuery : IRequest<IList<CarDto>>
    {

    }

    public class GetCarsQueryHandler : IRequestHandler<GetCarsQuery, IList<CarDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetCarsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IList<CarDto>> Handle(GetCarsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Cars
                .ProjectTo<CarDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
