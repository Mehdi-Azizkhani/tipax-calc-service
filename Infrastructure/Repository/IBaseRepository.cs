namespace Infrastructure.Repository;

public interface IBaseRepository
{
    public Task SaveChangesAsync();
}
