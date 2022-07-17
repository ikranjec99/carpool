namespace Carpool.Domain.Entities
{
    public class TravelPlanEmployee
    {
        public Guid Id { get; set; }
        public TravelPlan TravelPlan { get; set; }
        public Guid TravelPlanId { get; set; }
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
