using Contact.Domain.Abstracts;
using Contact.Domain.Enums;
using Contact.Domain.Interfaces;

namespace Contact.Domain.Entities;

public class PersonContact : BaseEntity, ISoftDeletableEntity
{
    public ContactType Type { get; set; }
    public string Value { get; set; }
    public Guid PersonId { get; set; }
    public bool IsDeleted { get; set; }

    public virtual Person Person { get; set; }
}