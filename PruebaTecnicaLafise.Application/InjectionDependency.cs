using Microsoft.Extensions.DependencyInjection;

namespace PruebaTecnicaLafise.Application
{
    public static class InjectionDependency
    {
        public static IServiceCollection AddServicesCollectionService(this IServiceCollection services)
        {
            return services;
        }
    }
}
