using Microsoft.Extensions.DependencyInjection;
using Todo.Negocio.Tareas;

namespace Todo.Negocio
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ITareasNegocio, TareasNegocio>();
            return services;
        }
    }
}
