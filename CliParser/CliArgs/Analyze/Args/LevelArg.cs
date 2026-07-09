namespace CliParser.CliArgs.Analyze.AnalyzeArgs
{
    internal class LevelArg : ICliArg
    {
        public LevelArg()
        {
            Name = ["level", "--level", "--l"];
            Help = "Filter the log file to only include entries that have the specified log level";
        }
        public string[] Name { get; }
        public string Help { get; }
    }
}
