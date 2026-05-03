
using CompaniOn.Infrastructure;
using CompaniOn.Application;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace CompaniOn.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            var connectionStringConfig = builder.BindConfig<ConnectionStringConfig>("ConnectionStrings");
            var jwtTokenConfig = builder.BindConfig<JwtTokenConfig>("JwtToken");

            builder.Services.AddMapper();
            builder.Services.AddValidators();
            builder.Services.AddApplication();
            builder.Services.AddInfrastructure();
            builder.Services.AddDatabase(connectionStringConfig);
            builder.Services.AddAuthenticationAndAuthorization(jwtTokenConfig);
            builder.Services.AddResponseCaching();
            builder.Services.AddOther();
            builder.Services.AddControllers().AddNewtonsoftJson()
                                  .AddJsonOptions(options =>
                                  {
                                      options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                                      options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                                  });

            builder.Services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
            builder.Services.AddCors(options => options.AddPolicy(
                name: "CorsPolicy",
                builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
            ));

            builder.Services.Configure<ApiBehaviorOptions>(options => options.SuppressModelStateInvalidFilter = true);

            if (builder.Environment.IsDevelopment())
            {
                builder.Services.AddSwagger();
            }

            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("CorsPolicy");
            app.UseHttpsRedirection();
            app.UseResponseCaching();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
