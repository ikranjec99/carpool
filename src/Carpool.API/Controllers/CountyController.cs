using Carpool.Application.Common.Models;
using Carpool.Application.Counties.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Carpool.API.Controllers
{
    [Route("api/counties")]
    public class CountyController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public CountyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get paginated counties 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetCounties([FromQuery]QueryOptions queryOptions)
        {
            return Ok(await _mediator.Send(new GetPaginatedCountiesQuery(queryOptions)));
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchCounties(string query)
        {
            return Ok(await _mediator.Send(new GetSearchedCountiesQuery(query)));
        }
    }
}
