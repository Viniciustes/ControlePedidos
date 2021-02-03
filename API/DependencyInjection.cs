using Interface.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Repository.Repositories;

namespace API
{
    public class DependencyInjection
    {
        public static void Register(IServiceCollection services)
        {
            RepositoryDependency(services);
        }

        private static void RepositoryDependency(IServiceCollection services)
        {
            services.AddScoped<IRepositoryCidade, RepositoryCidade>();
        }
    }
}