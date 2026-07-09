using Microsoft.Extensions.DependencyInjection;

namespace LogScope.DependencyInjection
{
    public static class DependencyResolver
    {
        public static ServiceCollection RegisterConcreteTypes(this ServiceCollection serviceCollection)
        {

            return serviceCollection;
        }
    }
}
