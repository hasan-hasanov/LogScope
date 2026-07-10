using System.CommandLine.Parsing;

namespace CliParser.Validations.OptionValidations
{
    public interface IOptionValidation
    {
        Task Validate(OptionResult result, CancellationToken cancellationToken);
    }
}
