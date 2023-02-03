using Contact.Application.Abstracts;

namespace Contact.Application.Commands.CreateNewContact;

public class CreateNewContactCommandResult : ResponseBase
{
    public Guid Id { get; set; }
}