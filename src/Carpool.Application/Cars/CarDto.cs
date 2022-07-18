using AutoMapper;
using Carpool.Application.Common.Mappings;
using Carpool.Domain.Entities;

namespace Carpool.Application.Cars
{
    public class CarDto : IMapFrom<Car>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CarMakeName { get; set; }
        public int CarMakeId { get;set; }
        public string CarModel { get; set; }
        public string ColorName { get; set; }
        public int ColorId { get; set; }
        public string Plates { get; set; }
        public int NumberOfSeats { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Car, CarDto>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.Name))
                .ForMember(d => d.CarMakeName, opt => opt.MapFrom(s => s.CarMake.Name))
                .ForMember(d => d.CarMakeId, opt => opt.MapFrom(s => s.CarMake.Id))
                .ForMember(d => d.ColorName, opt => opt.MapFrom(s => s.Color.Name))
                .ForMember(d => d.ColorId, opt => opt.MapFrom(s => s.Color.Id))
                .ForMember(d => d.Plates, opt => opt.MapFrom(s => s.Plates))
                .ForMember(d => d.NumberOfSeats, opt => opt.MapFrom(s => s.NumberOfSeats));
        }
    }
}
