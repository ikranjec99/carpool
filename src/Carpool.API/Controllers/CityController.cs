using Carpool.Application.Cities.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Carpool.API.Controllers
{
    [Route("api/cities")]
    public class CityController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public CityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get list of cities by search term 
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        [HttpGet("search")]
        public async Task<IActionResult> GetCities(string searchTerm)
        {
            return Ok(await _mediator.Send(new GetSearchedCitiesQuery(searchTerm)));
        }
    }
}
