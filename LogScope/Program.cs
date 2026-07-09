using CliParser;
using LogScope.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace LogScope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IServiceProvider serviceProvider = new ServiceCollection()
               .RegisterConcreteTypes()
               .BuildServiceProvider();

            var parser = serviceProvider.GetService<ICommandLineArgParser>();
        }
    }
}
