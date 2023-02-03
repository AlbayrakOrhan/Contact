using Contact.Application.Interfaces;
using Contact.Domain.Entities;
using Contact.Persistence.Context;

namespace Contact.Persistence.Repositories;

public class PersonRepository : GenericRepository<Person>, IPersonRepository
{
    public PersonRepository(ContactDbContext context) : base(context)
    {
    }
}