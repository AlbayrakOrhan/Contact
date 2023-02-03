using Contact.Application.Interfaces;
using Contact.Domain.Entities;
using Contact.Persistence.Context;

namespace Contact.Persistence.Repositories;

public class PersonContactRepository : GenericRepository<PersonContact>, IPersonContactRepository
{
    public PersonContactRepository(ContactDbContext context) : base(context)
    {
    }
}