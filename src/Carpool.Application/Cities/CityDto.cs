using AutoMapper;
using Carpool.Application.Common.Mappings;
using Carpool.Domain.Entities;

namespace Carpool.Application.Cities
{
    public class CityDto : IMapFrom<City>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CountyName { get; set; }
        public int CountyId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<City, CityDto>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.Name))
                .ForMember(d => d.CountyName, opt => opt.MapFrom(s => s.County.Name))
                .ForMember(d => d.CountyId, opt => opt.MapFrom(s => s.County.Id));
        }
    }
}
