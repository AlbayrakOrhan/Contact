using Contact.Application.Commands.CreateNewPerson;
using Contact.Application.Interfaces;
using Contact.Domain.Entities;
using MediatR;

namespace Contact.Application.Handlers;

public class CreateNewPersonCommandHandler : IRequestHandler<CreateNewPersonCommand, CreateNewPersonCommandResult>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPersonRepository _personRepository;

    public CreateNewPersonCommandHandler(IUnitOfWork unitOfWork, IPersonRepository personRepository)
    {
        _unitOfWork = unitOfWork;
        _personRepository = personRepository;
    }

    public async Task<CreateNewPersonCommandResult> Handle(CreateNewPersonCommand request, CancellationToken cancellationToken)
    {
        var newPerson = new Person()
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Company = request.Company,
        };

        await _personRepository.Save(newPerson);
        await _unitOfWork.SaveChangesAsync();

        return new CreateNewPersonCommandResult()
        {
            Id = newPerson.Id
        };
    }
}