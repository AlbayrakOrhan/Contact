using Contact.Application.Commands.DeletePerson;
using Contact.Application.Interfaces;
using MediatR;

namespace Contact.Application.Handlers;

public class DeletePersonCommandHandler : IRequestHandler<DeletePersonCommand, DeletePersonCommandResult>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPersonRepository _personRepository;

    public DeletePersonCommandHandler(IUnitOfWork unitOfWork, IPersonRepository personRepository)
    {
        _unitOfWork = unitOfWork;
        _personRepository = personRepository;
    }

    public async Task<DeletePersonCommandResult> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
    {
        var person = await _personRepository.GetById(request.Id);
        if (person == null)
        {
            throw new Exception("Person not found");
        }

        _personRepository.Delete(person);
        await _unitOfWork.SaveChangesAsync();

        return new DeletePersonCommandResult();
    }
}