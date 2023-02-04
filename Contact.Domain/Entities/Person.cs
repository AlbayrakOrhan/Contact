using Contact.Domain.Abstracts;
using Contact.Domain.Interfaces;

namespace Contact.Domain.Entities;

public class Person : EntityBase, ISoftDeletableEntity
{
    public Person()
    {
        Contacts = new HashSet<PersonContact>();
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Company { get; set; }
    public bool IsDeleted { get; set; }

    public virtual ICollection<PersonContact> Contacts { get; set; }
}