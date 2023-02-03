using Contact.Domain.Commons;
using Contact.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Contact.Domain.EntityConfigurations;

public class PersonConfiguration : BaseEntityConfiguration<Person>
{
    protected override void Configure(EntityTypeBuilder<Person> eb)
    {
    }
}