using CliParser.Validations.OptionValidations;
using System.CommandLine;

namespace CliParser.RootArguments.Options
{
    public class ExportOptionBuilder : IOptionsBuilder
    {
        private readonly IOptionValidation _validateFileNotExists;

        public ExportOptionBuilder(IEnumerable<IOptionValidation> optionValidations)
        {
            _validateFileNotExists = optionValidations.OfType<ValidateFileNotExists>().Single();
        }

        public Task<Option> Build(CancellationToken cancellationToken)
        {
            var exportOption = new Option<string>("export", "--export", "-e")
            {
                Description = "Export the filtered logs to a specified file.",
            };

            exportOption.Validators.Add(async optionResult => { await _validateFileNotExists.Validate(optionResult, cancellationToken); });

            return Task.FromResult<Option>(exportOption);
        }
    }
}
