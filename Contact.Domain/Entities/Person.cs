using Contact.Domain.Commons;

namespace Contact.Domain.Entities;

public class Person : BaseEntity
{
    public Person()
    {
        Contacts = new HashSet<PersonContact>();
    }
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Company { get; set; }

    public virtual ICollection<PersonContact> Contacts { get; set; }
}