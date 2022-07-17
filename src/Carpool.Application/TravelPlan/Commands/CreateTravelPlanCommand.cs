using Carpool.Application.Common.Interfaces;
using Carpool.Domain.Entities;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Carpool.Application.TravelPlan.Commands
{
    public class CreateTravelPlanCommand : IRequest<Unit>
    {
        public Guid CarId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid StartLocationId { get; set; }
        public Guid EndLocationId { get; set; }
        public IEnumerable<Guid> Employees { get; set; }
    }

    public class CreateTravelPlanCommandValidator : AbstractValidator<CreateTravelPlanCommand>
    {
        public CreateTravelPlanCommandValidator()
        {
            RuleFor(x => x.CarId).NotEmpty();
            RuleFor(x => x.StartDate).NotEmpty().LessThan(x => x.EndDate);
            RuleFor(x => x.EndDate).NotEmpty().GreaterThan(x => x.StartDate);
            RuleFor(x => x.StartLocationId).NotEmpty().NotEqual(x => x.EndLocationId);
            RuleFor(x => x.EndLocationId).NotEmpty().NotEqual(x => x.StartLocationId);
            RuleFor(x => x.Employees).NotEmpty();
        }
    }

    public class CreateTravelPlanCommandHandler : IRequestHandler<CreateTravelPlanCommand, Unit>
    {
        private readonly IApplicationDbContext _context;
        private readonly IDateTime _dateTime;

        public CreateTravelPlanCommandHandler(IApplicationDbContext context, IDateTime dateTime)
        {
            _context = context;
            _dateTime = dateTime;
        }

        public async Task<Unit> Handle(CreateTravelPlanCommand request, CancellationToken cancellationToken)
        {
            var now = _dateTime.Now;

            var isCarFree = await _context.TravelPlans
                .Where(x => x.CarId == request.CarId && request.StartDate >= x.EndDate)
                .AnyAsync();

            if (!isCarFree)
                throw new Exception("Car is not available in selected time range!");

            var car = await _context.Cars
                .Where(x => x.Id == request.CarId)
                .FirstOrDefaultAsync();

            if (car == null)
                throw new Exception($"Car with ID: {request.CarId} does not exist in database!");

            var carOvercrowded = car.NumberOfSeats < request.Employees.Count();

            if (carOvercrowded)
                throw new Exception($"Car is overcrowded! Max number of passengers is {car.NumberOfSeats}!");

            var employees = await _context.Employees
                .Where(x => request.Employees.Contains(x.Id))
                .ToListAsync();

            if (employees == null && employees.Count() == 0)
                throw new Exception("Selected employees do not exist in database!");

            var atlastOneDriver = employees.Count(x => x.IsDriver) >= 1;

            if (!atlastOneDriver)
                throw new Exception("There is no one with driving license in selected employee list!");

            var travelPlan = new Domain.Entities.TravelPlan
            {
                Id = Guid.NewGuid(),
                CarId = request.CarId,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                CreatedAt = now,
                UpdatedAt = now
            };

            _context.TravelPlans.Add(travelPlan);

            var travelPlanStartLocation = new TravelPlanStartLocation
            {
                Id = Guid.NewGuid(),
                CityId = request.StartLocationId,
                TravelPlanId = travelPlan.Id,
                CreatedAt = now,
                UpdatedAt = now
            };

            _context.TravelPlanStartLocations.Add(travelPlanStartLocation);

            var travelPlanEndLocation = new TravelPlanEndLocation
            {
                Id = Guid.NewGuid(),
                CityId = request.EndLocationId,
                TravelPlanId = travelPlan.Id,
                CreatedAt = now,
                UpdatedAt = now
            };

            _context.TravelPlanEndLocations.Add(travelPlanEndLocation);

            foreach (var employeeId in request.Employees)
            {
                var currentEmployee = await _context.Employees
                    .Where(x => x.Id == employeeId)
                    .FirstOrDefaultAsync();

                var travelPlanEmployee = new TravelPlanEmployee
                {
                    Id = Guid.NewGuid(),
                    TravelPlanId = travelPlan.Id,
                    EmployeeId = employeeId,
                    CreatedAt = now,
                    UpdatedAt = now
                };

                _context.TravelPlanEmployees.Add(travelPlanEmployee);
            }

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
