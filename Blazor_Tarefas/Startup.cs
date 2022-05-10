using Blazor_Tarefas.Repositorios;
using Blazor_Tarefas.Servicos;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor_Tarefas
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ServiceSingleton>();
            services.AddScoped<ServicoScoped>();
            services.AddTransient<ServicoTransient>();
            services.AddScoped<IRepositorio, Repositorio>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
