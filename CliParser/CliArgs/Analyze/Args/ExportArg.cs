namespace CliParser.CliArgs.Analyze.AnalyzeArgs
{
    internal class ExportArg : ICliArg
    {
        public ExportArg()
        {
            Name = ["export", "--export", "--e"];
            Help = "Export the filtered log file to a new file.";
        }

        public string[] Name { get; }

        public string Help { get; }
    }
}
