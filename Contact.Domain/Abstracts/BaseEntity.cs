namespace Contact.Domain.Abstracts;

public abstract class BaseEntity
{
    public virtual Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }

    public void SetId(Guid id)
    {
        Id = id;
    }
}