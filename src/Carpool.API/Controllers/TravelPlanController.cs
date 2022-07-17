using Carpool.Application.Common.Models;
using Carpool.Application.TravelPlan.Commands;
using Carpool.Application.TravelPlan.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Carpool.API.Controllers
{
    [Route("api/travel-plan")]
    public class TravelPlanController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public TravelPlanController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Create travel plan
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateTravelPlan(CreateTravelPlanCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        /// <summary>
        /// Update travel plan
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdateTravelPlan(UpdateTravelPlanCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        /// <summary>
        /// Delete travel plan
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> DeleteTravelPlan(DeleteTravelPlanCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        /// <summary>
        /// Get travel plan
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTravelPlan(Guid id)
        {
            return Ok(await _mediator.Send(new GetTravelPlanQuery { TravelPlanId = id }));
        }

        /// <summary>
        /// Get paginated travel plans
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetTravelPlans([FromQuery] QueryOptions queryOptions)
        {
            return Ok(await _mediator.Send(new GetTravelPlansQuery(queryOptions)));
        }
    }
}
