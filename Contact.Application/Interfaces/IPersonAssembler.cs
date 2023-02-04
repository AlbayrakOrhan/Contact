using Contact.Application.Commands.CreateNewPerson;
using Contact.Application.Dtos;
using Contact.Application.Queries.GetPersonDetail;
using Contact.Application.Queries.ListPerson;
using Contact.Domain.Entities;

namespace Contact.Application.Interfaces;

public interface IPersonAssembler
{
    Person MapToPersonEntity(CreateNewPersonCommand command);
    CreateNewPersonCommandResult MapToCreateNewPersonCommandResult(Person entity);
    ListPersonQueryResult MapToListPersonQueryResult(List<PersonDto> persons);
    GetPersonDetailQueryResult MapToGetPersonDetailQueryResult(Person person, List<PersonContactDto> contacts);
}