using Microsoft.Extensions.DependencyInjection;
using MinimalApi.Application.Abstractions;
using MinimalApi.Application.Services;

namespace MinimalApi.Application
{
    public static class ApplicationExtension
    {
        public static void AddAplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ITodoService, TodoService>();
        }
    }
}
