using System.CommandLine.Parsing;

namespace CliParser.Validations.ArgumentValidations
{
    public class ValidateFileFormat : IArgumentValidation
    {
        private readonly Func<string, string> _fileExtension;

        public ValidateFileFormat()
        {
            _fileExtension = fileName =>
            {
                return Path.GetExtension(fileName);
            };
        }

        public Task Validate(ArgumentResult result, CancellationToken cancellationToken)
        {
            var logFile = result.GetValueOrDefault<string>();

            if (_fileExtension.Invoke(logFile).ToLower() != ".json")
            {
                result.AddError($"The specified log file '{logFile}' is not a JSON file.");
            }

            return Task.CompletedTask;
        }
    }
}
