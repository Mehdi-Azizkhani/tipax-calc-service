using AutoMapper;
using Domain.Common;
using Domain.Dto.Service;
using Domain.Entities.Service;
using Domain.Interfaces;
using Infrastructure.Data;
using Infrastructure.Mappers;
using Infrastructure.Repository;

namespace Application.Services;

public class ServiceEntityService : BaseService
{
    private readonly IServiceEntityRepository _serviceEntityRepository;
    private readonly IMapper _mapper;

    public ServiceEntityService(
        AppDbContext dbContext,
        IServiceEntityRepository serviceRepository,
        IMapper mapper
        ) : base(dbContext)
    {
        _serviceEntityRepository = serviceRepository;
        _mapper = mapper;
    }

    public async Task<ServiceDto> CreateAsync(ServiceDto dto)
    {
        ServiceEntity serviceEntity = _mapper.Map<ServiceEntity>(dto);

        ServiceEntity newEntity = await _serviceEntityRepository.AddAsync(serviceEntity);

        return _mapper.Map<ServiceDto>(newEntity)!;
    }

    public async Task<ServiceDto> UpdateAsync(ServiceDto dto)
    {
        ServiceEntity? entity = await _serviceEntityRepository.GetByIdAsync(dto.Id);

        if (entity == null)
        {
            throw new Exception(Messages.ServiceEntityNotFound);
        }

        entity = _mapper.Map(dto, entity);

        ServiceEntity updatedEntity = await _serviceEntityRepository.UpdateAsync(entity);

        return _mapper.Map<ServiceDto>(updatedEntity)!;
    }

    public async Task DeleteAsync(int id)
    {
        if (!await _serviceEntityRepository.ExistsAsync(id))
        {
            throw new Exception(Messages.ServiceEntityNotFound);
        }

        await _serviceEntityRepository.DeleteAsync(id);
    }

    public async Task<ServiceDto?> GetByIdAsync(int id)
    {
        ServiceEntity? entity = await _serviceEntityRepository.GetByIdAsync(id);

        return _mapper.Map<ServiceDto>(entity);
    }

    public async Task<List<ServiceDto>> GetAllAsync()
    {
        List<ServiceEntity> entities = await _serviceEntityRepository.GetAllAsync();

        return entities.Select(x => _mapper.Map<ServiceDto>(x)!).ToList();
    }
}
