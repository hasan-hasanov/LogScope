namespace CliParser
{
    public interface ICommandLineArgParser
    {
        public Task<ArgumentResult> Parse(string[] args);
    }
}
