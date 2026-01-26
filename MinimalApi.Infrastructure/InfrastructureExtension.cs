using Microsoft.Extensions.DependencyInjection;
using MinimalApi.Core.Repositories;
using MinimalApi.Infrastructure.Repositories;

namespace MinimalApi.Infrastructure
{
    public static class InfrastructureExtension
    {
        public static void AddInfrastructureExtensions(this IServiceCollection services)
        {
            services.AddScoped<ITodoRepository, TodoRepository>();
        }
    }
}
