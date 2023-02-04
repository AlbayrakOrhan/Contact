using Contact.Application.Dtos;
using Contact.Domain.Entities;

namespace Contact.Application.Interfaces;

public interface IPersonContactRepository : IGenericRepository<PersonContact>
{
    Task<List<PersonContactDto>> ListByPersonId(Guid personId);
}