using Etities.Concrate;
using FluentValidation;

namespace Business.ValidationRules;

public class CarValidator : AbstractValidator<Car>
{
    public CarValidator()
    {
        RuleFor(c => c.DailyPrice).LessThan(7000);

        RuleFor(c => c.DailyPrice).NotEmpty();

        RuleFor(c => c.ModelYear).GreaterThan(1999);
    }
}