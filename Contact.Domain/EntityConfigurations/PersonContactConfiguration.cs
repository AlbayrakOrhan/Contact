using Contact.Domain.Abstracts;
using Contact.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Contact.Domain.EntityConfigurations;

public class PersonContactConfiguration : EntityConfigurationBase<PersonContact>
{
    protected override void Configure(EntityTypeBuilder<PersonContact> eb)
    {
    }
}