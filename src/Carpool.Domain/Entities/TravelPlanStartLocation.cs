namespace Carpool.Domain.Entities
{
    public class TravelPlanStartLocation
    {
        public Guid Id { get; set; }
        public City City { get; set; }
        public Guid CityId { get; set; }
        public TravelPlan TravelPlan { get; set; }
        public Guid TravelPlanId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
