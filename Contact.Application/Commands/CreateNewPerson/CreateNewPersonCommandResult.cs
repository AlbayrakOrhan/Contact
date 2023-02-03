using Contact.Application.Abstracts;

namespace Contact.Application.Commands.CreateNewPerson;

public class CreateNewPersonCommandResult : ResponseBase
{
    public Guid Id { get; set; }
}