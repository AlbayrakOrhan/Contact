using Contact.Application.Interfaces;
using Contact.Application.Queries.GetPersonDetail;
using MediatR;

namespace Contact.Application.Handlers;

public class GetPersonDetailQueryHandler : IRequestHandler<GetPersonDetailQuery, GetPersonDetailQueryResult>
{
    private readonly IPersonRepository _personRepository;

    public GetPersonDetailQueryHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<GetPersonDetailQueryResult> Handle(GetPersonDetailQuery request, CancellationToken cancellationToken)
    {
        return new GetPersonDetailQueryResult();
    }
}