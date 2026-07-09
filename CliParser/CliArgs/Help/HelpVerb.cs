namespace CliParser.CliArgs.Help
{
    public class HelpVerb : ICliArg
    {
        public HelpVerb()
        {
            Name = ["help", "--help", "h", "--h"];
            Help = "Displays help information for the command.";
        }

        public string[] Name { get; }

        public string Help { get; }
    }
}
