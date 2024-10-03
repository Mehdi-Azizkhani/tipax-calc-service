using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappers(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ServiceMapperProfile));
        }
    }
}
