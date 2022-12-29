using architecture.traditional.Domain.Repository;
using architecture.traditional.Domain.Services;
using architecture.traditional.Infrastructure.Context;
using architecture.traditional.Infrastructure.Interfaces;
using architecture.traditional.Infrastructure.Repositories;

namespace architecture.traditional.API.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static void ResolveCustomDependences(this IServiceCollection services)
        {
            services.AddScoped<IPersonServices, PersonServices>();
            services.AddScoped<IRepository<object>, Repository<object>>();
            services.AddScoped<PersonDbContext>();

        }
    }
}