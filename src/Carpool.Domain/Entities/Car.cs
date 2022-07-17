namespace Carpool.Domain.Entities
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public CarMake CarMake { get; set; }
        public int CarMakeId { get; set; }
        public string CarModel { get; set; }
        public Color Color { get; set; }
        public int ColorId { get; set; }
        public string Plates { get; set; }
        public int NumberOfSeats { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
