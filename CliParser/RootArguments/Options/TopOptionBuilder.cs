using System.CommandLine;

namespace CliParser.RootArguments.Options
{
    public class TopOptionBuilder : IOptionsBuilder
    {
        public Task<Option> Build(CancellationToken cancellationToken)
        {
            var topOption = new Option<int>("top", "--top", "-t")
            {
                Description = "Filter logs that contain the specified string.",
            };

            return Task.FromResult<Option>(topOption);
        }
    }
}
