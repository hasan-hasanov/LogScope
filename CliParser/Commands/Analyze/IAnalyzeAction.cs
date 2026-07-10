using System.CommandLine;

namespace CliParser.Commands.Analyze
{
    public interface IAnalyzeAction
    {
        Task ParseResult(ParseResult parseResult, CancellationToken cancellationToken);
    }
}
