using CliParser.Validations.ArgumentValidations;
using System.CommandLine;

namespace CliParser.RootArguments.Arguments
{
    public class LogFileArgumentBuilder : IArgumentBuilder
    {
        private readonly IArgumentValidation _validateFileExists;
        private readonly IArgumentValidation _validateFileFormat;

        public LogFileArgumentBuilder(IEnumerable<IArgumentValidation> argumentValidations)
        {
            _validateFileExists = argumentValidations.OfType<ValidateFileExists>().Single();
            _validateFileFormat = argumentValidations.OfType<ValidateFileFormat>().Single();
        }

        public async Task<Argument> Build(CancellationToken cancellationToken)
        {
            Argument<string> logFileArgument = new Argument<string>("log")
            {
                Description = "The log file to analyze. Only json is supported",
            };

            logFileArgument.Validators.Add(async (result) => { await _validateFileFormat.Validate(result, cancellationToken); });
            logFileArgument.Validators.Add(async (result) => { await _validateFileExists.Validate(result, cancellationToken); });

            return logFileArgument;
        }
    }
}
