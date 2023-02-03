using FluentValidation;

namespace Contact.Application.Commands.CreateNewContact;

public class CreateNewContactCommandValidator : AbstractValidator<CreateNewContactCommand>
{
    public CreateNewContactCommandValidator()
    {
        RuleFor(x => x.PersonId).NotEqual(default(Guid));
        RuleFor(x => x.Type).IsInEnum();
        RuleFor(x => x.Value).NotEmpty();
    }
}