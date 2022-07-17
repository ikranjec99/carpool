using Carpool.Application.Common.Interfaces;
using Carpool.Domain.Entities;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Carpool.Application.TravelPlan.Commands
{
    public class UpdateTravelPlanCommand : IRequest<Unit>
    {
        public Guid TravelPlanId { get; set; }
        public Guid CarId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid StartLocationId { get; set; }
        public Guid EndLocationId { get; set; }
        public IEnumerable<Guid> Employees { get; set; }
    }

    public class UpdateTravelPlanCommandValidator : AbstractValidator<UpdateTravelPlanCommand>
    {
        public UpdateTravelPlanCommandValidator()
        {
            RuleFor(x => x.TravelPlanId).NotEmpty();
            RuleFor(x => x.CarId).NotEmpty();
            RuleFor(x => x.StartDate).NotEmpty().LessThan(x => x.EndDate);
            RuleFor(x => x.EndDate).NotEmpty().GreaterThan(x => x.StartDate);
            RuleFor(x => x.StartLocationId).NotEmpty().NotEqual(x => x.EndLocationId);
            RuleFor(x => x.EndLocationId).NotEmpty().NotEqual(x => x.StartLocationId);
            RuleFor(x => x.Employees).NotEmpty();
        }
    }

    public class UpdateTravelPlanCommandHandler : IRequestHandler<UpdateTravelPlanCommand, Unit>
    {
        private readonly IApplicationDbContext _context;
        private readonly IDateTime _dateTime;

        public UpdateTravelPlanCommandHandler(IApplicationDbContext context, IDateTime dateTime)
        {
            _context = context;
            _dateTime = dateTime;
        }

        public async Task<Unit> Handle(UpdateTravelPlanCommand request, CancellationToken cancellationToken)
        {
            var now = _dateTime.Now;

            var travelPlan = await _context.TravelPlans
                .Where(x => x.Id == request.TravelPlanId && !x.DeletedAt.HasValue)
                .FirstOrDefaultAsync();

            if (travelPlan == null)
                throw new Exception($"Travel plan with ID: {request.TravelPlanId} does not exist!");

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

            travelPlan.CarId = request.CarId;
            travelPlan.StartDate = request.StartDate;
            travelPlan.EndDate = request.EndDate;
            travelPlan.UpdatedAt = now;
            travelPlan.DeletedAt = null;

            _context.TravelPlans.Update(travelPlan);

            var travelPlanStartLocation = await _context.TravelPlanStartLocations
                .Where(x => x.Id == request.StartLocationId)
                .FirstOrDefaultAsync();

            if (travelPlanStartLocation == null)
                throw new Exception("Travel plan start location does not exist!");

            travelPlanStartLocation.CityId = request.StartLocationId;
            travelPlanStartLocation.UpdatedAt = now;

            _context.TravelPlanStartLocations.Update(travelPlanStartLocation);

            var travelPlanEndLocation = await _context.TravelPlanEndLocations
                .Where(x => x.Id == request.EndLocationId)
                .FirstOrDefaultAsync();

            if (travelPlanEndLocation == null)
                throw new Exception("Travel plan end location does not exist!");

            travelPlanEndLocation.CityId = request.StartLocationId;
            travelPlanEndLocation.UpdatedAt = now;

            _context.TravelPlanEndLocations.Update(travelPlanEndLocation);

            var currentTravelPlanEmployees = await _context.TravelPlanEmployees
                .Where(x => x.TravelPlanId == travelPlan.Id && !x.DeletedAt.HasValue)
                .ToListAsync();

            if (currentTravelPlanEmployees == null && currentTravelPlanEmployees.Count() == 0)
                throw new Exception("No employees were found regarding current travel plan!");

            foreach (var currentEmployee in currentTravelPlanEmployees)
            {
                currentEmployee.UpdatedAt = now;
                currentEmployee.DeletedAt = now;

                _context.TravelPlanEmployees.Update(currentEmployee);
            }

            foreach (var employee in request.Employees)
            {
                var travelPlanEmployee = new TravelPlanEmployee
                {
                    Id = Guid.NewGuid(),
                    TravelPlanId = request.TravelPlanId,
                    EmployeeId = employee,
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
