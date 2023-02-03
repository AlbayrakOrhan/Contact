using Contact.Domain.Entities;
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
        modelBuilder.Entity<PersonContact>()
            .HasOne(x => x.Person)
            .WithMany(x => x.Contacts)
            .HasForeignKey(x => x.PersonId);
    }

    public DbSet<Person> Persons { get; set; }
    public DbSet<PersonContact> Contacts { get; set; }
}