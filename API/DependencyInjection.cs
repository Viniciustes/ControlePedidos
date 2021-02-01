using Microsoft.Extensions.DependencyInjection;
using System;

namespace API
{
    public class DependencyInjection
    {
        public static void Register(IServiceCollection services)
        {
            RepositoryDependence(services);
        }

        private static void RepositoryDependence(IServiceCollection services)
        {
            throw new NotImplementedException();
        }
    }
}