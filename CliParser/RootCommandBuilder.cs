using CliParser.Commands;
using System.CommandLine;

namespace CliParser
{
    public class RootCommandBuilder : IRootCommandBuilder
    {
        private readonly IEnumerable<ICommandBuilder> _commandBuilders;

        public RootCommandBuilder(IEnumerable<ICommandBuilder> commandBuilders)
        {
            _commandBuilders = commandBuilders;
        }

        public async Task<RootCommand> Build(CancellationToken cancellationToken)
        {
            var rootCommand = new RootCommand();

            foreach (var commandBuilder in _commandBuilders)
            {
                var command = await commandBuilder.Build(cancellationToken);
                rootCommand.Subcommands.Add(command);
            }

            return rootCommand;
        }
    }
}
