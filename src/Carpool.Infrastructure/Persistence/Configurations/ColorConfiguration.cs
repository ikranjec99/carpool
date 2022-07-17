using Carpool.Domain.Entities;
using Carpool.Domain.Enums.CarColor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Infrastructure.Persistence.Configurations
{
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.Property(t => t.Id)
                .IsRequired();

            builder.Property(t => t.Name)
                .IsRequired();

            builder.HasIndex(e => e.Name)
                .IsUnique();

            var enumValues = new List<int>((int[])Enum.GetValues(typeof(ColorEnum)));

            builder.HasData(enumValues.Select(t => new Color()
            {
                Id = t,
                Name = ((ColorEnum)t).ToString()
            }));
        }
    }
}
