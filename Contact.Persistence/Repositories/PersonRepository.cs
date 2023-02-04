using Contact.Application.Dtos;
using Contact.Application.Interfaces;
using Contact.Domain.Entities;
using Contact.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Contact.Persistence.Repositories;

public class PersonRepository : GenericRepository<Person>, IPersonRepository
{
    public PersonRepository(ContactDbContext context) : base(context)
    {
    }

    public async Task<List<PersonDto>> GetAllPersons()
    {
        return await Where(x => !x.IsDeleted).Select(x => new PersonDto()
        {
            Id = x.Id,
            FirstName = x.FirstName,
            LastName = x.LastName,
            Company = x.Company
        }).ToListAsync();
    }
}