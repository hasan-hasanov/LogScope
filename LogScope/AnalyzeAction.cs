using CliParser.Commands.Analyze;
using LogScope.Models;
using System.CommandLine;
using System.Text.Json;

namespace LogScope
{
    public class AnalyzeAction : IAnalyzeAction
    {
        public async Task ParseResult(ParseResult parseResult, CancellationToken cancellationToken)
        {
            var logFile = parseResult.GetValue<string>("log");
            var contains = parseResult.GetValue<string>("contains");
            var correlationId = parseResult.GetValue<string>("correlationid");
            var exportFile = parseResult.GetValue<string>("export");
            var level = parseResult.GetValue<string>("level");
            var top = parseResult.GetValue<int>("top");

            await foreach (string line in File.ReadLinesAsync(logFile, cancellationToken))
            {
                LogModel logModel = null;

                try
                {
                    logModel = JsonSerializer.Deserialize<LogModel>(line);
                }
                catch (Exception)
                {
                    Console.WriteLine("Failed to deserialize log line: " + line);
                }

                if (logModel == null || logModel.Level == null || logModel.Message == null)
                {
                    Console.WriteLine("Failed to deserialize log line: " + line);
                    continue;
                }
            }
        }
    }
}
