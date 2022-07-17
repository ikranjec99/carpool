using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Infrastructure.Persistence.Configurations
{
    public class TravelPlanEmployeeConfiguration : IEntityTypeConfiguration<TravelPlanEmployee>
    {
        public void Configure(EntityTypeBuilder<TravelPlanEmployee> builder)
        {
            builder.Property(t => t.Id)
                .IsRequired();

            builder.Property(t => t.TravelPlanId)
                .IsRequired();

            builder.Property(t => t.EmployeeId)
                .IsRequired();
        }
    }
}
