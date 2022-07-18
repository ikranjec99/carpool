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
        /// Get list of counties 
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetCounties()
        {
            return Ok(await _mediator.Send(new GetCountiesQuery()));
        }


        /// <summary>
        /// Get counties that match search term
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        [HttpGet("search")]
        public async Task<IActionResult> SearchCounties(string query)
        {
            return Ok(await _mediator.Send(new GetSearchedCountiesQuery(query)));
        }
    }
}
