using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;

namespace Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<AgricultureAndAnimalHusbandryWebAPIDbContext>(options => options.UseNpgsql(Configuration.ConfigurationString));
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<AgricultureAndAnimalHusbandryWebAPIDbContext>().AddDefaultTokenProviders();

            

            //services.AddScoped<IMenuReadRepository, MenuReadRepository>();
            //services.AddScoped<IMenuWriteRepository, MenuWriteRepository>();

            //services.AddScoped<IEndpointReadRepository, EndpointReadRepository>();
            //services.AddScoped<IEndpointWriteRepository, EndpointWriteRepository>();

            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<IAuthService, AuthService>();
            //services.AddScoped<IExternalAuthhentication, AuthService>();
            //services.AddScoped<IInternalAuthhentication, AuthService>();
            //services.AddScoped<IRoleService, RoleService>();
            //services.AddScoped<IAuthorizationEndpointService, AuthorizationEndpointService>();
        }
    }
}
