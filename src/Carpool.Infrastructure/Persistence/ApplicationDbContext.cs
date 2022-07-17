using Carpool.Application.Common.Interfaces;
using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Carpool.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<CarMake> CarMakes { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<TravelPlan> TravelPlans { get; set; }
        public DbSet<TravelPlanStartLocation> TravelPlanStartLocations { get; set; }
        public DbSet<TravelPlanEndLocation> TravelPlanEndLocations { get; set; }
        public DbSet<TravelPlanEmployee> TravelPlanEmployees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
