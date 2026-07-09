namespace CliParser.CliArgs
{
    public interface ICliArgParser
    {
        Task<ArgumentResult> Parse(Stack<string> args);
    }
}
