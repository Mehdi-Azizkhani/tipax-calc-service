using Domain.Entities.Service;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;
using Domain.Interfaces;

namespace Infrastructure.Repository;

public interface IServiceEntityRepository : IBaseRepository
{
    public Task<bool> ExistsAsync(int id);

    public Task<ServiceEntity?> GetByIdAsync(int id);

    public Task<List<ServiceEntity>> GetAllAsync();

    public Task<ServiceEntity> AddAsync(ServiceEntity serviceEntity);

    public Task<ServiceEntity> UpdateAsync(ServiceEntity serviceEntity);

    public Task DeleteAsync(int id);
}

public class ServiceEntityRepository : BaseRepository<ServiceEntity>, IServiceEntityRepository
{
    public ServiceEntityRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<ServiceEntity> AddAsync(ServiceEntity serviceEntity)
    {
        ServiceEntity entity = AddUserModifyData(serviceEntity);

        EntityEntry<ServiceEntity> entityEntry = await DbContext.Services.AddAsync(entity);

        await SaveChangesAsync();

        return entityEntry.Entity;
    }

    public async Task<ServiceEntity> UpdateAsync(ServiceEntity serviceEntity)
    {
        ServiceEntity entity = UpdateUserModifyData(serviceEntity);

        EntityEntry<ServiceEntity> entityEntry = DbContext.Services.Update(entity);

        await SaveChangesAsync();

        return entityEntry.Entity;
    }

    public async Task DeleteAsync(int id)
    {
        DbContext.Services.Remove(new ServiceEntity { Id = id });

        await SaveChangesAsync();
    }

    public Task<List<ServiceEntity>> GetAllAsync()
    {
        return DbContext.Services.ToListAsync();
    }

    public async Task<ServiceEntity?> GetByIdAsync(int id)
    {
        return await DbContext.Services.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<bool> ExistsAsync(int id)
    {
        return await DbContext.Services.AnyAsync(x => x.Id == id);
    }
}
