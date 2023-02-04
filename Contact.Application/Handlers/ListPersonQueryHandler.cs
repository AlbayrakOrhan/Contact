using Contact.Application.Interfaces;
using Contact.Application.Queries.ListPerson;
using MediatR;

namespace Contact.Application.Handlers;

public class ListPersonQueryHandler : IRequestHandler<ListPersonQuery, ListPersonQueryResult>
{
    private readonly IPersonRepository _personRepository;
    private readonly IPersonAssembler _personAssembler;

    public ListPersonQueryHandler(IPersonRepository personRepository, IPersonAssembler personAssembler)
    {
        _personRepository = personRepository;
        _personAssembler = personAssembler;
    }

    public async Task<ListPersonQueryResult> Handle(ListPersonQuery request, CancellationToken cancellationToken)
    {
        return _personAssembler.MapToListPersonQueryResult(await _personRepository.GetAllPersons());
    }
}