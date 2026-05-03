
using CompaniOn.Infrastructure.Interfaces;
using CompaniOn.Infrastructure.Interfaces.Repositories;
using CompaniOn.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
namespace CompaniOn.Infrastructure
{
    public static class Registry
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ICountriesRepository, CountriesRepository>();
            services.AddScoped<IPhotosRepository,PhotosRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<IGendersRepository, GendersRepository>();
            services.AddScoped<IRolesRepository, RolesRepository>();
            services.AddScoped<IAIConversationsRepository, AIConversationsRepository>();
            services.AddScoped<IHealthProfileRepository, HealthProfileRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
