using Infrastructure.Data;

namespace Application.Services;

public class BaseService
{
    public AppDbContext DbContext { get; }

    public BaseService(AppDbContext dbContext)
    {
        DbContext = dbContext;
    }

}
