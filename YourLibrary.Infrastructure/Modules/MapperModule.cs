using Microsoft.Extensions.DependencyInjection;
using AutoMapper;

namespace YourLibrary.Infrastructure.Modules
{
    public static class MapperModule
    {
        public static void AddMapperModule(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MapperModule));
        }
    }
}
