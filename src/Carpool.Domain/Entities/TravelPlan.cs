namespace Carpool.Domain.Entities
{
    public class TravelPlan
    {
        public Guid Id { get; set; }
        public Car Car { get; set; }
        public Guid CarId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? CreatedAt { get;  set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<TravelPlanEmployee> TravelPlanEmployees { get; set; }
        public virtual TravelPlanStartLocation TravelPlanStartLocation { get; set; }
        public virtual TravelPlanEndLocation TravelPlanEndLocation { get; set; }
    }
}
