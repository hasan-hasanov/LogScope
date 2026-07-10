using CliParser.Commands.Analyze;
using System.CommandLine;

namespace LogScope
{
    public class AnalyzeAction : IAnalyzeAction
    {
        public Task ParseResult(ParseResult parseResult, CancellationToken cancellationToken)
        {
            var logFile = parseResult.GetValue<string>("log");
            var contains = parseResult.GetValue<string>("contains");
            var correlationId = parseResult.GetValue<string>("correlationid");
            var exportFile = parseResult.GetValue<string>("export");
            var level = parseResult.GetValue<string>("level");
            var top = parseResult.GetValue<int>("top");
            Console.WriteLine($"Log file: {logFile}");
            Console.WriteLine($"Contains: {contains}");
            Console.WriteLine($"Correlation ID: {correlationId}");
            Console.WriteLine($"Export file: {exportFile}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Top: {top}");

            return Task.CompletedTask;
        }
    }
}
