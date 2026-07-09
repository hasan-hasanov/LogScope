namespace CliParser.CliArgs.Analyze.AnalyzeArgs
{
    public class ContainsArg : ICliArg
    {
        public ContainsArg()
        {
            Name = ["contains", "--contains", "--c"];
            Help = "Filter the log file to only include entries that contain the specified string";
        }

        public string[] Name { get; }

        public string Help { get; }
    }
}
