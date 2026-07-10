using System.CommandLine;

namespace CliParser.RootArguments.Options
{
    public class CorrelationIdOptionBuilder : IOptionsBuilder
    {
        public Task<Option> Build(CancellationToken cancellationToken)
        {
            var correlationIdOption = new Option<string>("correlationid", "--correlationid", "--cid")
            {
                Description = "Filter logs that contain the specified correlation ID.",
            };

            return Task.FromResult<Option>(correlationIdOption);
        }
    }
}
