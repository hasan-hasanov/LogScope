using CliParser;
using LogScope.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace LogScope
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            args = args.Length == 0 ? new string[] { "analyze", "test.json", "--top", "100" } : args;

            IServiceProvider serviceProvider = new ServiceCollection()
               .RegisterConcreteTypes()
               .BuildServiceProvider();

            var rootCommandBuilder = serviceProvider.GetService<IRootCommandBuilder>();
            var rootCommand = await rootCommandBuilder.Build(CancellationToken.None);

            await rootCommand.Parse(args).InvokeAsync();
        }
    }
}
