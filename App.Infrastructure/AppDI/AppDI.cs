using App.Infrastructure.DBContext;
using App.Infrastructure.DefultData;
using App.Infrastructure.Interfaces;
using App.Infrastructure.Interfaces.Context;
using App.Infrastructure.Interfaces.Repository;
using App.Infrastructure.Mapping;
using App.Infrastructure.Persistence.DapperConfiguration;
using App.Infrastructure.Persistence.Seed;
using App.Infrastructure.Persistence.UnitOfWork;
using App.Infrastructure.Reposiotries.Configuration;
using Hangfire;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Globalization;
using System.Text;

namespace App.Infrastructure.AppDI
{
    public static class AppDI
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services, IConfiguration configuration)
        {
            
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddDbContextPool<dbContext>(options => options.UseSqlServer(configuration.GetConnectionString("SQLConnection")));
            services.AddSingleton<IErpInitilizerData, ErpInitilizerData>();
            services.AddScoped(typeof(IRepositoryQueryMaster<>), typeof(RepositoryQueryMaster<>));
            services.AddTransient<IApplicationSqlDbContext>(provider => provider.GetService<dbContext>());
            services.AddScoped(typeof(IRepositoryQuery<>), typeof(RepositoryQuery<>));
            services.AddScoped(typeof(IRepositoryCommand<>), typeof(RepositoryCommand<>));
            services.AddScoped<IApplicationWriteDbConnection, ApplicationWriteDbConnection>();
            services.AddScoped<DbFactory>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<Func<dbContext>>((provider) => () => provider.GetService<dbContext>());
            services.AddScoped<IApplicationReadDbConnection, ApplicationReadDbConnection>();
            services.AddScoped<dbContext>();
            services.AddTransient<IApplicationSqlDbContext>(provider => provider.GetService<dbContext>());
            services.AddHttpClient();
            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = defultData.site,
                    ValidateAudience = true,
                    ValidAudience = defultData.site,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(defultData.JWT_SECURITY_KEY)),
                    ClockSkew = TimeSpan.Zero
                };
            });
            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("en-NZ");
                options.SupportedCultures = new List<CultureInfo> { new CultureInfo("en-US"), new CultureInfo("en-NZ") };
            });
            services.AddHangfire(x => x.UseSqlServerStorage(configuration.GetConnectionString("SQLConnection")));
            services.AddHangfireServer();
            services.AddMvc().AddJsonOptions(option => option.JsonSerializerOptions.PropertyNamingPolicy = null);
            services.AddDistributedMemoryCache();
            services.AddSession();
            services.AddHttpClient("MyCilent", client =>
            {
                client.Timeout = TimeSpan.FromMinutes(10);
            });
            services.AddSignalR();
            services.AddMemoryCache();






            return services;
        }
    }
}
