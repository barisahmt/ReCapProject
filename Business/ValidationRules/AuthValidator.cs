using Core.Entities.Concrate;
using FluentValidation;

namespace Business.ValidationRules;

public class AuthValidator : AbstractValidator<User>
{
    public AuthValidator()
    {
        RuleFor(u => u.FirstName.Length).GreaterThan(2).WithMessage("It must be greater than 2");
        RuleFor(u => u.FirstName.Length).LessThan(10).WithMessage("It must be lest than 10");

        RuleFor(u => u.LastName.Length).LessThan(2).WithMessage("It must be lest than 2");
        RuleFor(u => u.LastName.Length).LessThan(10).WithMessage("It must be lest than 10");
    }
}