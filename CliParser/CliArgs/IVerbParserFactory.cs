namespace CliParser.CliArgs
{
    public interface IVerbParserFactory
    {
        ICliArgParser this[string key] { get; }
    }
}
