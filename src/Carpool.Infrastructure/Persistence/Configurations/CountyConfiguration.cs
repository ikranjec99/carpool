using Carpool.Domain.Entities;
using Carpool.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carpool.Infrastructure.Persistence.Configurations
{
    public class CountyConfiguration : IEntityTypeConfiguration<County>
    {
        public void Configure(EntityTypeBuilder<County> builder)
        {
            builder.Property(t => t.Id)
                .IsRequired();

            builder.Property(t => t.Name)
                .IsRequired();

            builder.HasIndex(t => t.Name)
                .IsUnique();

            builder.HasData(
                new County
                {
                    Id = (int)CountyEnum.BjelovarskoBilogorska,
                    Name = "Bjelovarsko-bilogorska"
                },
                new County
                {
                    Id = (int)CountyEnum.BrodskoPosavska,
                    Name = "Brodsko-posavska"
                },
                new County
                {
                    Id = (int)CountyEnum.DubrovackoNeretvanska,
                    Name = "Dubrovačko-neretvanska"
                },
                new County
                {
                    Id = (int)CountyEnum.Istarska,
                    Name = "Istarska"
                },
                new County
                {
                    Id = (int)CountyEnum.Karlovacka,
                    Name = "Karlovačka"
                },
                new County
                {
                    Id = (int)CountyEnum.KoprivnickoKrizevacka,
                    Name = "Koprivničko-križevačka"
                },
                new County
                {
                    Id = (int)CountyEnum.KrapinskoZagorska,
                    Name = "Krapinsko-zagorska"
                },
                new County
                {
                    Id = (int)CountyEnum.LickoSenjska,
                    Name = "Ličko-senjska"
                },
                new County
                {
                    Id = (int)CountyEnum.Medimurska,
                    Name = "Međimurska"
                },
                new County
                {
                    Id = (int)CountyEnum.OsjeckoBaranjska,
                    Name = "Osječko-baranjska"
                },
                new County
                {
                    Id = (int)CountyEnum.PozeskoSlavnoska,
                    Name = "Požeško-slavonska"
                },
                new County
                {
                    Id = (int)CountyEnum.PrimorskoGoranska,
                    Name = "Primorsko-goranska"
                },
                new County
                {
                    Id = (int)CountyEnum.SisackoMoslavacka,
                    Name = "Sisačko-moslavačka"
                },
                new County
                {
                    Id = (int)CountyEnum.SplitskoDalmatinska,
                    Name = "Splitsko-dalmatinska"
                },
                new County
                {
                    Id = (int)CountyEnum.SibenskoKninska,
                    Name = "Šibensko-kninska"
                },
                new County
                {
                    Id = (int)CountyEnum.Varazdinska,
                    Name = "Varaždinska"
                },
                new County
                {
                    Id = (int)CountyEnum.VirovitickoPodravska,
                    Name = "Virovitičko-podravska"
                },
                new County
                {
                    Id = (int)CountyEnum.VukovarskoSrijemska,
                    Name = "Vukovarsko-srijemska"
                },
                new County
                {
                    Id = (int)CountyEnum.Zadarska,
                    Name = "Zadarska"
                },
                new County
                {
                    Id = (int)CountyEnum.Zagrebacka,
                    Name = "Zagrebačka"
                },
                new County
                {
                    Id = (int)CountyEnum.GradZagreb,
                    Name = "Grad Zagreb"
                }
            );
        }
    }
}
