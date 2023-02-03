using Contact.Application.Abstracts;
using Contact.Application.Dtos;

namespace Contact.Application.Queries.ListPerson;

public class ListPersonQueryResult : ResponseBase
{
    public ListPersonQueryResult()
    {
        Persons = new List<PersonDto>();
    }

    public List<PersonDto> Persons { get; set; }
}