using Carpool.Application.Cars.Queries;
using Carpool.Application.Common.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Carpool.API.Controllers
{
    [Route("api/cars")]
    public class CarController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public CarController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get list of all cars
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetCars()
        {
            return Ok(await _mediator.Send(new GetCarsQuery()));
        }


        /// <summary>
        /// Get list of all available cars
        /// </summary>
        /// <param name="StartDate"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        [HttpGet("available")]
        public async Task<IActionResult> GetAvailableCars(GetAvailableCarsQuery query)
        {
            return Ok(await _mediator.Send(query));
        }
    }
}
