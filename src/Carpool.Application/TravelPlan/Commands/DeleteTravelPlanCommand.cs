using Carpool.Application.Common.Interfaces;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Carpool.Application.TravelPlan.Commands
{
    public class DeleteTravelPlanCommand : IRequest<Unit>
    {
        public Guid TravelPlanId { get; set; }
    }

    public class DeleteTravelPlanCommandValidator : AbstractValidator<DeleteTravelPlanCommand>
    {
        public DeleteTravelPlanCommandValidator()
        {
            RuleFor(x => x.TravelPlanId).NotEmpty();
        }
    }

    public class DeleteTravelPlanCommandHandler : IRequestHandler<DeleteTravelPlanCommand, Unit>
    {
        private readonly IApplicationDbContext _context;
        private readonly IDateTime _dateTime;

        public DeleteTravelPlanCommandHandler(IApplicationDbContext context, IDateTime dateTime)
        {
            _context = context;
            _dateTime = dateTime;
        }

        public async Task<Unit> Handle(DeleteTravelPlanCommand request, CancellationToken cancellationToken)
        {
            var now = _dateTime.Now;

            var travelPlan = await _context.TravelPlans
                .Where(x => x.Id == request.TravelPlanId && !x.DeletedAt.HasValue)
                .FirstOrDefaultAsync();

            if (travelPlan == null)
                throw new Exception("Travel plan does not exist in database!");

            travelPlan.DeletedAt = now;

            _context.TravelPlans.Update(travelPlan);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
