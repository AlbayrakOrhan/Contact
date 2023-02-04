using Contact.Application.Commands.CreateNewPerson;
using Contact.Application.Dtos;
using Contact.Application.Interfaces;
using Contact.Application.Queries.GetPersonDetail;
using Contact.Application.Queries.ListPerson;
using Contact.Domain.Entities;

namespace Contact.Application.Assemblers;

public class PersonAssembler : IPersonAssembler
{
    public Person MapToPersonEntity(CreateNewPersonCommand command)
    {
        return new Person()
        {
            Id = Guid.NewGuid(),
            FirstName = command.FirstName,
            LastName = command.LastName,
            Company = command.Company,
        };
    }

    public CreateNewPersonCommandResult MapToCreateNewPersonCommandResult(Person entity)
    {
        return new CreateNewPersonCommandResult()
        {
            Id = entity.Id
        };
    }

    public ListPersonQueryResult MapToListPersonQueryResult(List<PersonDto> persons)
    {
        return new ListPersonQueryResult()
        {
            Persons = persons
        };
    }

    public GetPersonDetailQueryResult MapToGetPersonDetailQueryResult(Person person, List<PersonContactDto> contacts)
    {
        return new GetPersonDetailQueryResult()
        {
            Id = person.Id,
            FirstName = person.FirstName,
            LastName = person.LastName,
            Company = person.Company,
            Contacts = contacts
        };
    }
}