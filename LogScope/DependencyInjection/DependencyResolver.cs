using CliParser;
using CliParser.Commands;
using CliParser.Commands.Analyze;
using CliParser.RootArguments.Arguments;
using CliParser.RootArguments.Options;
using CliParser.Validations.ArgumentValidations;
using CliParser.Validations.OptionValidations;
using Microsoft.Extensions.DependencyInjection;

namespace LogScope.DependencyInjection
{
    public static class DependencyResolver
    {
        public static ServiceCollection RegisterConcreteTypes(this ServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IOptionValidation, ValidateFileNotExists>();

            serviceCollection.AddScoped<IArgumentValidation, ValidateFileExists>();
            serviceCollection.AddScoped<IArgumentValidation, ValidateFileFormat>();

            serviceCollection.AddScoped<IOptionsBuilder, ContainsOptionBuilder>();
            serviceCollection.AddScoped<IOptionsBuilder, CorrelationIdOptionBuilder>();
            serviceCollection.AddScoped<IOptionsBuilder, ExportOptionBuilder>();
            serviceCollection.AddScoped<IOptionsBuilder, LevelOptionBuilder>();
            serviceCollection.AddScoped<IOptionsBuilder, TopOptionBuilder>();

            serviceCollection.AddScoped<IArgumentBuilder, LogFileArgumentBuilder>();

            serviceCollection.AddScoped<ICommandBuilder, AnalyzeCommandBuilder>();
            serviceCollection.AddScoped<IRootCommandBuilder, RootCommandBuilder>();

            serviceCollection.AddScoped<IAnalyzeAction, AnalyzeAction>();

            return serviceCollection;
        }
    }
}
