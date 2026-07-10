using System.CommandLine;

namespace CliParser.RootArguments.Options
{
    public interface IOptionsBuilder
    {
        Task<Option> Build(CancellationToken cancellationToken);
    }
}
