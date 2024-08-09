using AirlineSystem.IOC;

namespace AirlineSystem.Api.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectConfigurations(this IServiceCollection services)
        {
            if (services == null)
            { 
                  throw new ArgumentNullException(nameof(services));
            }
            DependencyContainer.RegisterService(services);
        }
    }
}
