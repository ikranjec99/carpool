using Carpool.Application.TravelPlan.Commands;
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
    }
}
