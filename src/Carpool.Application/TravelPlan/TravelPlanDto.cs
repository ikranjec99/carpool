using AutoMapper;
using Carpool.Application.Common.Mappings;
using Carpool.Domain.Entities;

namespace Carpool.Application.TravelPlan
{
    public class TravelPlanDto : IMapFrom<Domain.Entities.TravelPlan>
    {
        public Guid Id { get; set; }
        public Car Car { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string TravelPlanStartLocation { get; set; }
        public Guid TravelPlanStartLocationId { get; set; }
        public string TravelPlanEndLocation { get; set; }
        public Guid TravelPlanEndLocationId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.TravelPlan, TravelPlanDto>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.Car, opt => opt.MapFrom(s => s.Car))
                .ForMember(d => d.StartDate, opt => opt.MapFrom(s => s.StartDate))
                .ForMember(d => d.EndDate, opt => opt.MapFrom(s => s.EndDate))
                .ForMember(d => d.TravelPlanStartLocation, opt => opt.MapFrom(s => s.TravelPlanStartLocation.City.Name))
                .ForMember(d => d.TravelPlanEndLocation, opt => opt.MapFrom(s => s.TravelPlanEndLocation.City.Name));
        }
    }
}
