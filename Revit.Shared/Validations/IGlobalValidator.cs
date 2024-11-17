using FluentValidation.Results;

namespace Revit.Shared.Validations
{
    public interface IGlobalValidator
    {
        ValidationResult Validate<T>(T model);
    }
}