using AutoMapper;
using Domain.Dto.Service;
using Domain.Entities.Service;

namespace Infrastructure.Mappers;

public class ServiceMapperProfile: Profile
{
    public ServiceMapperProfile()
    {
        CreateMap<ServiceDto, ServiceEntity>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.UserId, opt => opt.Ignore())
            .ForMember(dest => dest.CreationDate, opt => opt.Ignore())
            .ForMember(dest => dest.ModificationDate, opt => opt.Ignore());

        CreateMap<ServiceEntity, ServiceDto>();

        CreateMap<ServiceEntity, ServiceEntity>();
    }
}
