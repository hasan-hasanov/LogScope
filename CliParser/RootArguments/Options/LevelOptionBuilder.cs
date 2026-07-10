using System.CommandLine;

namespace CliParser.RootArguments.Options
{
    public class LevelOptionBuilder : IOptionsBuilder
    {
        public Task<Option> Build(CancellationToken cancellationToken)
        {
            var levelOption = new Option<string>("level", "--level", "-l")
            {
                Description = "Filter logs by the specified log level (e.g., Information, Warning, Error).",
            };

            return Task.FromResult<Option>(levelOption);
        }
    }
}
