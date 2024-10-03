using Application.Services;
using Infrastructure.Data;
using Infrastructure.Mappers;
using Infrastructure.Repository;

namespace Api.Configurations;

public static partial class Configurations
{
    public static void ConfigureServices(IServiceCollection services)
    {
        AutoMapperConfig.RegisterMappers(services);

        services.AddScoped<ServiceEntityService>();

        services.AddScoped<IServiceEntityRepository, ServiceEntityRepository>();

        ConfigureDefaultServices(services);
    }

    private static void ConfigureDefaultServices(IServiceCollection services)
    {

        services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }
}
