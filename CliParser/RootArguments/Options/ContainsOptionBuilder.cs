using System.CommandLine;

namespace CliParser.RootArguments.Options
{
    public class ContainsOptionBuilder : IOptionsBuilder
    {
        public Task<Option> Build(CancellationToken cancellationToken)
        {
            var containsOption = new Option<string>("contains", "--contains", "-c")
            {
                Description = "Filter logs that contain the specified string.",
            };

            return Task.FromResult<Option>(containsOption);
        }
    }
}
