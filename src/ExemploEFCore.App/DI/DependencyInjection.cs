
using ExemploEFCore.App.Models;
using ExemploEFCore.App.Interfaces;
using ExemploEFCore.App.Services;
using ExemploEFCore.App.Context;
using ExemploEFCore.App.Data;
using Microsoft.Extensions.DependencyInjection;

namespace ExemploEFCore.App.DI
{
    public static class DependencyInjection
    {
        public static void ConfigureServices(ref ServiceProvider serviceProvider)
        {
            var services = new ServiceCollection();

            services.AddScoped<ApplicationDbContext>();
            services.AddScoped<IAlunoRepository, AlunoRepository>();
            services.AddScoped<IAlunoService, AlunoService>();
            serviceProvider = services.BuildServiceProvider();
        }
    }
}

