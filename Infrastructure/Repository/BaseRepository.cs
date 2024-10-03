using Domain.Entities.Service;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Infrastructure.Repository;

public class BaseRepository<TEntity>
    where TEntity: IEntity
{
    public AppDbContext DbContext { get; }

    public BaseRepository(AppDbContext dbContext)
    {
        DbContext = dbContext;
    }

    public async Task SaveChangesAsync()
    {
        await DbContext.SaveChangesAsync();
    }

    public TEntity AddUserModifyData(TEntity entity)
    {
        if (entity is IUserModifyAware userModifyAware)
        {
            userModifyAware.UserId = 1; //Todo: Need to set user id
            userModifyAware.CreationDate = DateTime.Now;
        }

        return entity;
    }

    public TEntity UpdateUserModifyData(TEntity entity)
    {
        if (entity is IUserModifyAware userModifyAware)
        {
            userModifyAware.ModificationDate = DateTime.Now;
        }
        return entity;
    }
}
