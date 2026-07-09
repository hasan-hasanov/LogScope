using CliParser.CliArgs;
using CliParser.CliArgs.Exceptions;
using CliParser.CliArgs.Help.Parsers;
using System.Text;

namespace CliParser
{
    public class CommandLineArgParser : ICommandLineArgParser
    {
        private readonly IVerbParserFactory _verbParserFactory;

        public CommandLineArgParser(IVerbParserFactory verbParserFactory)
        {
            _verbParserFactory = verbParserFactory;
        }

        public async Task<ArgumentResult> Parse(string[] args)
        {
            ICliArgParser parser = new HelpVerbParser();
            Stack<string> cliArgs = new Stack<string>();

            if (args.Any())
            {
                cliArgs = new Stack<string>(args.Reverse());
                string verb = cliArgs.Pop();

                parser = _verbParserFactory[verb];
                if (parser == null)
                {
                    StringBuilder helpBuilder = new StringBuilder()
                        .AppendLine($"Command '{verb}' is not recognized! Try:")
                        .AppendLine()
                        .AppendLine("    boxer help");

                    throw new VerbNotFoundException(helpBuilder.ToString());
                }
            }

            var result = await parser.Parse(cliArgs);

            return result;
        }
    }
}
