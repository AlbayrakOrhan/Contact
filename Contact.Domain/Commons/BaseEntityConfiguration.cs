using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Contact.Domain.Commons;

public abstract class BaseEntityConfiguration<T> where T : BaseEntity
{
    protected abstract void Configure(EntityTypeBuilder<T> eb);

    public void BaseConfiguration(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<T>(eb =>
        {
            eb.HasKey(b => b.Id);
            eb.Property(b => b.CreatedDate);
            eb.Property(b => b.ModifiedDate);
            Configure(eb);
        });
    }
}