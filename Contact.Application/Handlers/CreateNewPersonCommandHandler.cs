using Contact.Application.Commands.CreateNewPerson;
using Contact.Application.Interfaces;
using MediatR;

namespace Contact.Application.Handlers;

public class CreateNewPersonCommandHandler : IRequestHandler<CreateNewPersonCommand, CreateNewPersonCommandResult>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPersonRepository _personRepository;
    private readonly IPersonAssembler _personAssembler;

    public CreateNewPersonCommandHandler(IUnitOfWork unitOfWork, IPersonRepository personRepository, IPersonAssembler personAssembler)
    {
        _unitOfWork = unitOfWork;
        _personRepository = personRepository;
        _personAssembler = personAssembler;
    }

    public async Task<CreateNewPersonCommandResult> Handle(CreateNewPersonCommand request, CancellationToken cancellationToken)
    {
        var newPerson = _personAssembler.MapToPersonEntity(request);
        await _personRepository.Save(newPerson);
        await _unitOfWork.SaveChangesAsync();

        return _personAssembler.MapToCreateNewPersonCommandResult(newPerson);
    }
}