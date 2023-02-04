using Contact.Application.Interfaces;
using Contact.Application.Queries.GetPersonDetail;
using MediatR;

namespace Contact.Application.Handlers;

public class GetPersonDetailQueryHandler : IRequestHandler<GetPersonDetailQuery, GetPersonDetailQueryResult>
{
    private readonly IPersonRepository _personRepository;
    private readonly IPersonContactRepository _personContactRepository;
    private readonly IPersonAssembler _personAssembler;

    public GetPersonDetailQueryHandler(IPersonRepository personRepository, IPersonContactRepository personContactRepository, IPersonAssembler personAssembler)
    {
        _personRepository = personRepository;
        _personContactRepository = personContactRepository;
        _personAssembler = personAssembler;
    }

    public async Task<GetPersonDetailQueryResult> Handle(GetPersonDetailQuery request, CancellationToken cancellationToken)
    {
        var person = await _personRepository.GetById(request.Id);
        if (person == null)
        {
            throw new Exception("Person not found");
        }

        var contacts = await _personContactRepository.ListByPersonId(person.Id);

        return _personAssembler.MapToGetPersonDetailQueryResult(person, contacts);
    }
}