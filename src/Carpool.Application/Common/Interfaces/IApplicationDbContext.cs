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
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
