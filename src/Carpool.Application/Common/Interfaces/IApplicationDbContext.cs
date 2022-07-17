using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carpool.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<CarMake> CarMakes { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Domain.Entities.TravelPlan> TravelPlans { get; set; }
        public DbSet<TravelPlanStartLocation> TravelPlanStartLocations { get; set; }
        public DbSet<TravelPlanEndLocation> TravelPlanEndLocations { get; set; }
        public DbSet<TravelPlanEmployee> TravelPlanEmployees { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
