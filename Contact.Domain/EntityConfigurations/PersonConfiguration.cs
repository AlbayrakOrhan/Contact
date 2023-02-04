using Contact.Domain.Abstracts;
using Contact.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Contact.Domain.EntityConfigurations;

public class PersonConfiguration : EntityConfigurationBase<Person>
{
    protected override void Configure(EntityTypeBuilder<Person> eb)
    {
        eb.Property(x => x.Company).IsRequired(false);
    }
}