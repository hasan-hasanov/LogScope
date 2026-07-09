namespace CliParser.CliArgs.Analyze.AnalyzeArgs
{
    internal class TopArg : ICliArg
    {
        public TopArg()
        {
            Name = ["top", "--top", "--t"];
            Help = "Filter the log file to anallyze only the top N entries";
        }

        public string[] Name { get; }

        public string Help { get; }
    }
}
