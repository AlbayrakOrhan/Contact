namespace Contact.Domain.Entities;

public class Person
{
    public Person()
    {
        Contacts = new HashSet<PersonContact>();
    }

    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Company { get; set; }

    public virtual ICollection<PersonContact> Contacts { get; set; }
}