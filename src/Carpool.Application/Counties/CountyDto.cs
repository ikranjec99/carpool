using AutoMapper;
using Carpool.Application.Common.Mappings;
using Carpool.Domain.Entities;

namespace Carpool.Application.Counties
{
    public class CountyDto : IMapFrom<County>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<County, CountyDto>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.Name));
        }
    }
}
