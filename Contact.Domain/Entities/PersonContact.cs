using Contact.Domain.Enums;

namespace Contact.Domain.Entities;

public class PersonContact
{
    public Guid Id { get; set; }
    public ContactType Type { get; set; }
    public string Value { get; set; }
    public Guid PersonId { get; set; }

    public virtual Person Person { get; set; }
}