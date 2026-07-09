namespace CliParser.CliArgs.Analyze.AnalyzeArgs
{
    public class CorrelationIdArg : ICliArg
    {
        public CorrelationIdArg()
        {
            Name = ["correlationId", "correlationid", "--correlationid", "--correlationId", "--cid"];
            Help = "Filter the log file to only include entries that have the specified correlation id";
        }

        public string[] Name { get; }

        public string Help { get; }
    }
}
