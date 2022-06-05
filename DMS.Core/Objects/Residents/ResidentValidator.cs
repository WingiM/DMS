using FluentValidation;

namespace DMS.Core.Objects.Residents;

public class ResidentValidator : AbstractValidator<Resident>
{
    public ResidentValidator()
    {
        RuleFor(res => res.PassportInformation)
            .NotNull()
            .WithMessage(ValidationMessages.NoPassport);
    }
}