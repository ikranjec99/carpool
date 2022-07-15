using Carpool.Domain.Entities;
using Carpool.Domain.Enums.CarMake;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Infrastructure.Persistance.Configurations
{
    public class CarMakeConfiguration : IEntityTypeConfiguration<CarMake>
    {
        public void Configure(EntityTypeBuilder<CarMake> builder)
        {
            builder.Property(t => t.Id)
                .IsRequired();

            builder.Property(t => t.Name)
                .IsRequired();

            builder.HasIndex(e => e.Name)
                .IsUnique();

            var enumValues = new List<int>((int[])Enum.GetValues(typeof(CarMakeEnum)));

            builder.HasData(enumValues.Select(t => new CarMake()
            {
                Id = t,
                Name = ((CarMakeEnum)t).ToString()
            }));
        }
    }
}
