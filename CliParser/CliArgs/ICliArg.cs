namespace CliParser.CliArgs
{
    public interface ICliArg
    {
        string[] Name { get; }

        string Help { get; }
    }
}
