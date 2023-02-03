using Contact.Domain.Commons;
using Contact.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Contact.Domain.EntityConfigurations;

public class PersonContactConfiguration : BaseEntityConfiguration<PersonContact>
{
    protected override void Configure(EntityTypeBuilder<PersonContact> eb)
    {
    }
}