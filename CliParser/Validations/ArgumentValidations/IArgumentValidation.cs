using System.CommandLine.Parsing;

namespace CliParser.Validations.ArgumentValidations
{
    public interface IArgumentValidation
    {
        Task Validate(ArgumentResult result, CancellationToken cancellationToken);
    }
}
