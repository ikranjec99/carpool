using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpool.Infrastructure.Persistence.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(t => t.Id)
                .IsRequired();

            builder.Property(t => t.EmployeeId)
                .IsRequired();

            builder.HasIndex(e => new { e.Id, e.EmployeeId })
                .IsUnique();

            builder.Property(e => e.EmployeeName)
                .IsRequired();

            builder.Property(e => e.IsDriver)
                .IsRequired();

            builder.HasData(
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 1,
                    EmployeeName = "Ivan Kranjec",
                    IsDriver = true
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 2,
                    EmployeeName = "Damir Rose",
                    IsDriver = false
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 3,
                    EmployeeName = "Ana Lazaric",
                    IsDriver = true
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 4,
                    EmployeeName = "Thomas Horvar",
                    IsDriver = true
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 5,
                    EmployeeName = "Marko Mlinarić",
                    IsDriver = true
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 6,
                    EmployeeName = "Josip Tandara",
                    IsDriver = true
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 7,
                    EmployeeName = "Marin Horvat",
                    IsDriver = false
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 8,
                    EmployeeName = "Dino Jelusić",
                    IsDriver = true
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 9,
                    EmployeeName = "Miroslav Škoro",
                    IsDriver = true
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 10,
                    EmployeeName = "Hrvoje Plenk",
                    IsDriver = true
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 11,
                    EmployeeName = "Matej Dušan",
                    IsDriver = false
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 12,
                    EmployeeName = "Peter Pan",
                    IsDriver = true
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 13,
                    EmployeeName = "Hrvoje Mirić",
                    IsDriver = true
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 14,
                    EmployeeName = "Jasna Gruber",
                    IsDriver = true
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 15,
                    EmployeeName = "Mario Budimir",
                    IsDriver = true
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 16,
                    EmployeeName = "Igor Babić",
                    IsDriver = true
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 17,
                    EmployeeName = "Marija Husar",
                    IsDriver = false
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 18,
                    EmployeeName = "Melita Huskvarnić",
                    IsDriver = true
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 19,
                    EmployeeName = "Lana Jurčević",
                    IsDriver = false
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 20,
                    EmployeeName = "Mihaela Dubrovnik",
                    IsDriver = false
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 21,
                    EmployeeName = "Ivan Ivanović",
                    IsDriver = true
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 22,
                    EmployeeName = "Luka Cvrtila",
                    IsDriver = true
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 23,
                    EmployeeName = "Dubravko Marček",
                    IsDriver = true
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 24,
                    EmployeeName = "Dubravka Martinić",
                    IsDriver = true
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = 25,
                    EmployeeName = "Nenad Kovaček",
                    IsDriver = true
                }
            );
        }
    }
}
