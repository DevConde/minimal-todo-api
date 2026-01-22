using Microsoft.Extensions.DependencyInjection;
using MinimalApi.Application.Services;
using MinimalApi.Core.Services;

namespace MinimalApi.Application
{
    public static class ApplicationExtension
    {
        public static void AddAplicationServices(this IServiceCollection services)
        {
            services.AddSingleton<ITodoService, TodoService>();
        }
    }
}
