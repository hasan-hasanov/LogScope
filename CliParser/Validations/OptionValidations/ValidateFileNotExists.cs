using System.CommandLine.Parsing;

namespace CliParser.Validations.OptionValidations
{
    public class ValidateFileNotExists : IOptionValidation
    {
        private readonly Func<string, bool> _fileExistsAction;

        public ValidateFileNotExists()
        {
            _fileExistsAction = fileName =>
            {
                return File.Exists(fileName);
            };
        }

        public Task Validate(OptionResult result, CancellationToken cancellationToken)
        {
            var logFile = result.GetValueOrDefault<string>();

            if (_fileExistsAction.Invoke(logFile))
            {
                result.AddError($"The specified file '{logFile}' already exist.");
            }

            return Task.CompletedTask;
        }
    }
}
