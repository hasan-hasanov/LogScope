using System.CommandLine;

namespace CliParser.Commands
{
    public interface ICommandBuilder
    {
        Task<Command> Build(CancellationToken cancellationToken);
    }
}
