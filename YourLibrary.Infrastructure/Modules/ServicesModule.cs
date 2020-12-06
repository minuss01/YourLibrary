using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using YourLibrary.Infrastructure.Services.Abstract;

namespace YourLibrary.Infrastructure.Modules
{
    public static class ServicesModule
    {
        public static void AddServicesModule(this IServiceCollection services)
        {
            Assembly assembly = typeof(ServicesModule)
                .GetTypeInfo()
                .Assembly;

            services.Scan(scan => scan
            .FromAssemblies(assembly)
            .AddClasses(classes => classes.AssignableTo<IService>())
            .AsImplementedInterfaces()
            .WithScopedLifetime());
        }
    }
}
