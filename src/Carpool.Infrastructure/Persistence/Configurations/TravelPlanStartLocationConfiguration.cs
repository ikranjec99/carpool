using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Infrastructure.Persistence.Configurations
{
    public class TravelPlanStartLocationConfiguration : IEntityTypeConfiguration<TravelPlanStartLocation>
    {

        public void Configure(EntityTypeBuilder<TravelPlanStartLocation> builder)
        {
            builder.Property(t => t.Id)
                .IsRequired();

            builder.Property(t => t.CityId)
                .IsRequired();

            builder.Property(t => t.TravelPlanId)
                .IsRequired();
        }
    }
}
