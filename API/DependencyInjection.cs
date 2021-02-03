using Microsoft.Extensions.DependencyInjection;

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
        }
    }
}