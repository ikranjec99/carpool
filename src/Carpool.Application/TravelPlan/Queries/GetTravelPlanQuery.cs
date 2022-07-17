using AutoMapper;
using AutoMapper.QueryableExtensions;
using Carpool.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpool.Application.TravelPlan.Queries
{
    public class GetTravelPlanQuery : IRequest<TravelPlanDto>
    {
        public Guid TravelPlanId { get; set; }
    }

    public class GetTravelPlanQueryHandler : IRequestHandler<GetTravelPlanQuery, TravelPlanDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetTravelPlanQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<TravelPlanDto> Handle(GetTravelPlanQuery request, CancellationToken cancellationToken)
        {
            var travelPlan = await _context.TravelPlans
                .Where(x => x.Id == request.TravelPlanId)
                .ProjectTo<TravelPlanDto>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();

            if (travelPlan == null)
                throw new Exception("Travel plan does not exist!!");

            return travelPlan;
        }
    }
}
