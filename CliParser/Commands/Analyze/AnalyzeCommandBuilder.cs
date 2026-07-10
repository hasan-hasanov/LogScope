using CliParser.RootArguments.Arguments;
using CliParser.RootArguments.Options;
using System.CommandLine;

namespace CliParser.Commands.Analyze
{
    public class AnalyzeCommandBuilder : ICommandBuilder
    {
        private readonly IArgumentBuilder _logFileArgument;

        private readonly IOptionsBuilder _containsOption;
        private readonly IOptionsBuilder _correlationIdOption;
        private readonly IOptionsBuilder _exportOption;
        private readonly IOptionsBuilder _levelOption;
        private readonly IOptionsBuilder _topOption;

        private readonly IAnalyzeAction _commandAction;

        public AnalyzeCommandBuilder(
            IEnumerable<IArgumentBuilder> arguments,
            IEnumerable<IOptionsBuilder> options,
            IAnalyzeAction commandAction)
        {
            _logFileArgument = arguments.OfType<LogFileArgumentBuilder>().Single();
            _containsOption = options.OfType<ContainsOptionBuilder>().Single();
            _correlationIdOption = options.OfType<CorrelationIdOptionBuilder>().Single();
            _exportOption = options.OfType<ExportOptionBuilder>().Single();
            _levelOption = options.OfType<LevelOptionBuilder>().Single();
            _topOption = options.OfType<TopOptionBuilder>().Single();
            _commandAction = commandAction;
        }

        public async Task<Command> Build(CancellationToken cancellationToken)
        {
            var analyzeCommand = new Command("analyze", "Analyze a log file")
            {
                Arguments = { await _logFileArgument.Build(cancellationToken) },
                Options =
                {
                    await _containsOption.Build(cancellationToken),
                    await _correlationIdOption.Build(cancellationToken),
                    await _exportOption.Build(cancellationToken),
                    await _levelOption.Build(cancellationToken),
                    await _topOption.Build(cancellationToken)
                }
            };

            analyzeCommand.SetAction(async result => { await _commandAction.ParseResult(result, cancellationToken); });

            return analyzeCommand;
        }
    }
}
