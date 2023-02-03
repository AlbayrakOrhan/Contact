using MediatR;

namespace Contact.Application.Commands.DeletePerson;

public class DeletePersonCommand : IRequest<DeletePersonCommandResult>
{
    public Guid Id { get; set; }
}