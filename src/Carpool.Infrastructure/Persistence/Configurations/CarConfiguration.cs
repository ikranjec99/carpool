using Carpool.Domain.Enums.CarColor;
using Carpool.Domain.Enums.CarMake;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpool.Infrastructure.Persistence.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Domain.Entities.Car>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Car> builder)
        {
            builder.Property(t => t.Id)
                .IsRequired();

            builder.Property(t => t.Name)
                .IsRequired();

            builder.Property(e => e.CarMake)
                .IsRequired();

            builder.Property(e => e.CarModel)
                .IsRequired();

            builder.Property(e => e.Color)
                .IsRequired();

            builder.Property(e => e.Plates)
                .IsRequired();

            builder.HasIndex(e => e.Plates)
                .IsUnique();

            builder.Property(e => e.NumberOfSeats)
                .IsRequired();

            builder.HasData(
                new Domain.Entities.Car
                {
                    Id = Guid.NewGuid(),
                    Name = "Milan's Golf",
                    CarMakeId = (int)CarMakeEnum.Volkswagen,
                    CarModel = "Golf VIII",
                    ColorId = (int)ColorEnum.Black,
                    Plates = "BJ-513-DD",
                    NumberOfSeats = 5
                },
                new Domain.Entities.Car
                {
                    Id = Guid.NewGuid(),
                    Name = "John's Mustang",
                    CarMakeId = (int)CarMakeEnum.Ford,
                    CarModel = "Mustang",
                    ColorId = (int)ColorEnum.Red,
                    Plates = "ZG-5220-IG",
                    NumberOfSeats = 3
                },
                new Domain.Entities.Car
                {
                    Id = Guid.NewGuid(),
                    Name = "Patricia's Volvo",
                    CarMakeId = (int)CarMakeEnum.Volvo,
                    CarModel = "V60",
                    ColorId = (int)ColorEnum.Brown,
                    Plates = "DU-555-PP",
                    NumberOfSeats = 5
                },
                new Domain.Entities.Car
                {
                    Id = Guid.NewGuid(),
                    Name = "Josip's Toyota",
                    CarMakeId = (int)CarMakeEnum.Toyota,
                    CarModel = "Supra",
                    ColorId = (int)ColorEnum.Gold,
                    Plates = "PU-2224-DC",
                    NumberOfSeats = 3
                },
                new Domain.Entities.Car
                {
                    Id = Guid.NewGuid(),
                    Name = "Damir's Skoda",
                    CarMakeId = (int)CarMakeEnum.Skoda,
                    CarModel = "Superb",
                    ColorId = (int)ColorEnum.Purple,
                    Plates = "ST-555-BD",
                    NumberOfSeats = 5
                },
                new Domain.Entities.Car
                {
                    Id = Guid.NewGuid(),
                    Name = "Ivan's Auid",
                    CarMakeId = (int)CarMakeEnum.Audi,
                    CarModel = "A5",
                    ColorId = (int)ColorEnum.White,
                    Plates = "PU-333-DB",
                    NumberOfSeats = 3
                },
                new Domain.Entities.Car
                {
                    Id = Guid.NewGuid(),
                    Name = "Lana's Seat",
                    CarMakeId = (int)CarMakeEnum.Seat,
                    CarModel = "Leon",
                    ColorId = (int)ColorEnum.Blue,
                    Plates = "KC-222-DA",
                    NumberOfSeats = 5
                },
                new Domain.Entities.Car
                {
                    Id = Guid.NewGuid(),
                    Name = "Silvija's Dacia",
                    CarMakeId = (int)CarMakeEnum.Dacia,
                    CarModel = "Sandero",
                    ColorId = (int)ColorEnum.Brown,
                    Plates = "NA-221-IA",
                    NumberOfSeats = 5
                },
                new Domain.Entities.Car
                {
                    Id = Guid.NewGuid(),
                    Name = "Tomislav's Suzuki",
                    CarMakeId = (int)CarMakeEnum.Suzuki,
                    CarModel = "SX4",
                    ColorId = (int)ColorEnum.Green,
                    Plates = "B-444-AA",
                    NumberOfSeats = 5
                },
                new Domain.Entities.Car
                {
                    Id = Guid.NewGuid(),
                    Name = "Nebojsa's Chevy",
                    CarMakeId = (int)CarMakeEnum.Chevrolet,
                    CarModel = "Captiva",
                    ColorId = (int)ColorEnum.Orange,
                    Plates = "RI-6776-DU",
                    NumberOfSeats = 5
                }
            );
        }
    }
}
