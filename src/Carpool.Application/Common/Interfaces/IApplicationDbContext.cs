using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carpool.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<CarMake> CarMakes { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
