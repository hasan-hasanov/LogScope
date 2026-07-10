using System.CommandLine;

namespace CliParser.RootArguments.Arguments
{
    public interface IArgumentBuilder
    {
        Task<Argument> Build(CancellationToken cancellationToken);
    }
}
