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
    public class GetTravelPlanQuery : IRequest<Domain.Entities.TravelPlan>
    {
        public Guid TravelPlanId { get; set; }
    }

    public class GetTravelPlanQueryHandler : IRequestHandler<GetTravelPlanQuery, Domain.Entities.TravelPlan>
    {
        private readonly IApplicationDbContext _context;

        public GetTravelPlanQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.TravelPlan> Handle(GetTravelPlanQuery request, CancellationToken cancellationToken)
        {
            var travelPlan = await _context.TravelPlans
                .Where(x => x.Id == request.TravelPlanId)
                .FirstOrDefaultAsync();

            if (travelPlan == null)
                throw new Exception("Travel plan does not exist!!");

            return travelPlan;
        }
    }
}
