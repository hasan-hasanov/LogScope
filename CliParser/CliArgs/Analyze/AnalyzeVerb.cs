namespace CliParser.CliArgs.Analyze
{
    public class AnalyzeVerb : ICliArg
    {
        public AnalyzeVerb()
        {
            Name = ["analyze", "--analyze", "--a"];
            Help = "Analyze the specified microsoft log file. Currently only json is supported";
        }

        public string[] Name { get; }

        public string Help { get; }
    }
}
