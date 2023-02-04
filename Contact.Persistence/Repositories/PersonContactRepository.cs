using Contact.Application.Dtos;
using Contact.Application.Interfaces;
using Contact.Domain.Entities;
using Contact.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Contact.Persistence.Repositories;

public class PersonContactRepository : GenericRepository<PersonContact>, IPersonContactRepository
{
    public PersonContactRepository(ContactDbContext context) : base(context)
    {
    }

    public async Task<List<PersonContactDto>> ListByPersonId(Guid personId)
    {
        return await Where(x => x.PersonId == personId && !x.IsDeleted).Select(x => new PersonContactDto()
        {
            Id = x.Id,
            ContactType = x.Type,
            Value = x.Value
        }).ToListAsync();
    }
}