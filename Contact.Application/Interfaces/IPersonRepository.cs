using Contact.Application.Dtos;
using Contact.Domain.Entities;

namespace Contact.Application.Interfaces;

public interface IPersonRepository : IGenericRepository<Person>
{
    Task<List<PersonDto>> GetAllPersons();
}