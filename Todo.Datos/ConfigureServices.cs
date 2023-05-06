using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Todo.Datos.Contexts;
using Todo.Datos.Repositorios.Estados.Implementacion;
using Todo.Datos.Repositorios.Estados.Interfaces;
using Todo.Datos.Repositorios.Tareas.Implementacion;
using Todo.Datos.Repositorios.Tareas.Interfaces;

namespace Todo.Datos
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<DapperContext>();
            services.AddScoped<ITareasRepositorio, TareasRepositorio>();
            services.AddScoped<IEstadosRepositorio, EstadosRepositorio>();
            return services;
        }
    }
}
