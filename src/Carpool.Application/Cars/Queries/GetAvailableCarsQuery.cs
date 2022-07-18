using AutoMapper;
using AutoMapper.QueryableExtensions;
using Carpool.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Carpool.Application.Cars.Queries
{
    public class GetAvailableCarsQuery : IRequest<IList<CarDto>>
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public GetAvailableCarsQuery(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
    }

    public class GetAvailableCarsQueryHandler : IRequestHandler<GetAvailableCarsQuery, IList<CarDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetAvailableCarsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IList<CarDto>> Handle(GetAvailableCarsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Cars
                .Include(x => x.TravelPlan)
                .Where(x => x.TravelPlan.EndDate <= request.StartDate && !x.TravelPlan.DeletedAt.HasValue)
                .ProjectTo<CarDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
