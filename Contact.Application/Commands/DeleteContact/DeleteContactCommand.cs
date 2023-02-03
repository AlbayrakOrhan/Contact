using MediatR;

namespace Contact.Application.Commands.DeleteContact;

public class DeleteContactCommand : IRequest<DeleteContactCommandResult>
{
    public Guid PersonId { get; set; }
    public Guid ContactId { get; set; }
}