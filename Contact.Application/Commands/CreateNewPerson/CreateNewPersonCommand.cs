using MediatR;

namespace Contact.Application.Commands.CreateNewPerson;

public class CreateNewPersonCommand : IRequest<CreateNewPersonCommandResult>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Company { get; set; }
}