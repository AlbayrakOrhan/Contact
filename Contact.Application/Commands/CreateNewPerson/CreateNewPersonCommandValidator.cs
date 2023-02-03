using FluentValidation;

namespace Contact.Application.Commands.CreateNewPerson;

public class CreateNewPersonCommandValidator : AbstractValidator<CreateNewPersonCommand>
{
    public CreateNewPersonCommandValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty();
        RuleFor(x => x.LastName).NotEmpty();
    }
}