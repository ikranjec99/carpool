﻿using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carpool.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<CarMake> CarMakes { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
