using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using YourLibrary.DB.Repositories.Abstract;

namespace YourLibrary.DB.Modules
{
    public static class RepositoriesModule
    {
        public static void AddRepositoriesModule(this IServiceCollection services)
        {
            Assembly assembly = typeof(RepositoriesModule)
                .GetTypeInfo()
                .Assembly;

            services.Scan(scan => scan
            .FromAssemblies(assembly)
            .AddClasses(classes => classes.AssignableTo<IRepository>())
            .AsImplementedInterfaces()
            .WithScopedLifetime());
        }
    }
}
