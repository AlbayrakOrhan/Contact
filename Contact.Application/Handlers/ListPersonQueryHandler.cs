using Contact.Application.Interfaces;
using Contact.Application.Queries.ListPerson;
using MediatR;

namespace Contact.Application.Handlers;

public class ListPersonQueryHandler : IRequestHandler<ListPersonQuery, ListPersonQueryResult>
{
    private readonly IPersonRepository _personRepository;

    public ListPersonQueryHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<ListPersonQueryResult> Handle(ListPersonQuery request, CancellationToken cancellationToken)
    {
        return new ListPersonQueryResult();
    }
}