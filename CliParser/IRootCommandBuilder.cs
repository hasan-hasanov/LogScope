using System.CommandLine;

namespace CliParser
{
    public interface IRootCommandBuilder
    {
        Task<RootCommand> Build(CancellationToken cancellationToken);
    }
}
