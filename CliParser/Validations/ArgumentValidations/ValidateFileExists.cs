using System.CommandLine.Parsing;

namespace CliParser.Validations.ArgumentValidations
{
    public class ValidateFileExists : IArgumentValidation
    {
        private readonly Func<string, bool> _fileExistsAction;

        public ValidateFileExists()
        {
            _fileExistsAction = fileName =>
            {
                return File.Exists(fileName);
            };
        }

        public Task Validate(ArgumentResult result, CancellationToken cancellationToken)
        {
            var logFile = result.GetValueOrDefault<string>();

            if (!_fileExistsAction.Invoke(logFile))
            {
                result.AddError($"The specified log file '{logFile}' does not exist.");
            }

            return Task.CompletedTask;
        }
    }
}
