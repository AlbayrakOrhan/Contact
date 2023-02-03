using MediatR;

namespace Contact.Application.Queries.GetPersonDetail;

public class GetPersonDetailQuery : IRequest<GetPersonDetailQueryResult>
{
    public Guid Id { get; set; }
}