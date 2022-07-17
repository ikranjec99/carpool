using AutoMapper;
using AutoMapper.QueryableExtensions;
using Carpool.Application.Common.Interfaces;
using Carpool.Application.Common.Mappings;
using Carpool.Application.Common.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpool.Application.TravelPlan.Queries
{
    public class GetTravelPlansQuery : IRequest<PaginatedList<TravelPlanDto>>
    {
        public QueryOptions QueryOptions { get; set; }

        public GetTravelPlansQuery(QueryOptions queryOptions)
        {
            QueryOptions = queryOptions;
        }
    }

    public class GetTravelPlansQueryHandler : IRequestHandler<GetTravelPlansQuery, PaginatedList<TravelPlanDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetTravelPlansQueryHandler(IApplicationDbContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginatedList<TravelPlanDto>> Handle(GetTravelPlansQuery request, CancellationToken cancellationToken)
        {
            return await _context.TravelPlans
                .Where(x => !x.DeletedAt.HasValue)
                .ProjectTo<TravelPlanDto>(_mapper.ConfigurationProvider)
                .PaginatedListAsync(request.QueryOptions.PageNumber, request.QueryOptions.PageSize);
        }
    }
}
