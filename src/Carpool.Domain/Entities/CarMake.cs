namespace Carpool.Domain.Entities
{
    public class CarMake
    {
        public int Id { get; set; }
        public string Name { get; set; }

        #region System properties
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        #endregion
    }
}
