using AutoMapper;
using AutoMapper.QueryableExtensions;
using Carpool.Application.Common.Interfaces;
using Carpool.Application.Common.Mappings;
using Carpool.Application.Common.Models;
using Carpool.Domain.Entities;
using MediatR;
using System;
namespace Carpool.Application.Counties.Queries
{
    public class GetPaginatedCountiesQuery : IRequest<PaginatedList<CountyDto>>
    {
        public QueryOptions QueryOptions { get; set; }

        public GetPaginatedCountiesQuery(QueryOptions queryOptions)
        {
            QueryOptions = queryOptions;
        }
    }

    public class GetPaginatedCountiesQueryHandler : IRequestHandler<GetPaginatedCountiesQuery, PaginatedList<CountyDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetPaginatedCountiesQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginatedList<CountyDto>> Handle(GetPaginatedCountiesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Counties
                .ProjectTo<CountyDto>(_mapper.ConfigurationProvider)
                .PaginatedListAsync(request.QueryOptions.PageNumber, request.QueryOptions.PageSize);
        }
    }
}
