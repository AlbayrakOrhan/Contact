using FluentValidation;

namespace Contact.Application.Commands.DeleteContact;

public class DeleteContactCommandValidator : AbstractValidator<DeleteContactCommand>
{
    public DeleteContactCommandValidator()
    {
        RuleFor(x => x.PersonId).NotEqual(default(Guid));
        RuleFor(x => x.ContactId).NotEqual(default(Guid));
    }
}