using CompaniOn.Application.Interfaces;
using CompaniOn.Core;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace CompaniOn.Application
{
    public static class Registry
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ICountriesService, CountriesService>();
            services.AddScoped<IPhotosService, PhotosService>();
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<IGendersService,GendersService>();
            services.AddScoped<IRolesService, RolesService>();
            services.AddScoped<IAIConversationsService, AIConversationsService>();
   
        }

        public static void AddValidators(this IServiceCollection services)
        {
            services.AddScoped<IValidator<CountryUpsertDto>, CountryValidator>();
            services.AddScoped<IValidator<PhotoUpsertDto>, PhotoValidator>();
            services.AddScoped<IValidator<UserUpsertDto>, UserValidator>();
            services.AddScoped<IValidator<GenderUpsertDto>, GenderValidator>();
            services.AddScoped<IValidator<RoleUpsertDto>, RoleValidator>();
            services.AddScoped<IValidator<UserChangePasswordDto>, UserPasswordValidator>();
            services.AddScoped<IValidator<AIConversationUpsertDto>, AIConversationValidator>();
        }
    }
}
