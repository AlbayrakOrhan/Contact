using Contact.Domain.Entities;
using Contact.Domain.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Contact.Persistence.Context;

public class ContactDbContext : DbContext
{
    public ContactDbContext(DbContextOptions options) : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new PersonConfiguration().BaseConfiguration(modelBuilder);
        new PersonContactConfiguration().BaseConfiguration(modelBuilder);
    }

    public DbSet<Person> Persons { get; set; }
    public DbSet<PersonContact> Contacts { get; set; }
}