using App.Core.BackgroundJobs;
using App.Core.Helper;
using App.Core.Services.ERPToolsValidationServices;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace App.Core.ServicesDI
{
	public static class ServicesDI
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddTransient<IRestfulAPIService, RestfulAPIService>();
            services.AddTransient<IERPToolsValidationService, ERPToolsValidationService>();
            services.AddHostedService<Pushdata>();


			return services;
        }
    }
}
