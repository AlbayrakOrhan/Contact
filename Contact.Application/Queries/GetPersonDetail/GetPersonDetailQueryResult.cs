using Contact.Application.Abstracts;
using Contact.Application.Dtos;

namespace Contact.Application.Queries.GetPersonDetail;

public class GetPersonDetailQueryResult : ResponseBase
{
    public GetPersonDetailQueryResult()
    {
        Contacts = new List<PersonContactDto>();
    }

    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Company { get; set; }
    public List<PersonContactDto> Contacts { get; set; }
}