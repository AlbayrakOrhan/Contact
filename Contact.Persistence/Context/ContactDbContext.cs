using Contact.Domain.Abstracts;
using Contact.Domain.Entities;
using Contact.Domain.EntityConfigurations;
using Contact.Domain.Interfaces;
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
        new PersonConfiguration().Configure(modelBuilder);
        new PersonContactConfiguration().Configure(modelBuilder);
    }

    public DbSet<Person> Persons { get; set; }
    public DbSet<PersonContact> Contacts { get; set; }

    public override int SaveChanges()
    {
        BeforeSave();
        return base.SaveChanges();
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        BeforeSave();
        return await base.SaveChangesAsync(cancellationToken);
    }

    private void BeforeSave()
    {
        ChangeTracker.DetectChanges();
        var added = ChangeTracker.Entries()
            .Where(t => t.State == EntityState.Added)
            .Select(t => t.Entity)
            .ToArray();

        foreach (var entity in added)
        {
            if (entity is EntityBase track)
            {
                track.CreatedDate = DateTime.Now;
            }
        }

        var deleted = ChangeTracker.Entries()
            .Where(t => t.State == EntityState.Deleted)
            .ToArray();
        foreach (var item in deleted)
        {
            if (item.Entity is not ISoftDeletableEntity entity)
                continue;

            entity.IsDeleted = true;
            item.State = EntityState.Modified;
        }

        var modified = ChangeTracker.Entries()
            .Where(t => t.State == EntityState.Modified)
            .Select(t => t.Entity)
            .ToArray();

        foreach (var entity in modified)
        {
            if (entity is EntityBase track)
            {
                track.ModifiedDate = DateTime.Now;
            }
        }
    }
}