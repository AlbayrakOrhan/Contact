using Contact.Application.Interfaces;
using Contact.Persistence.Context;

namespace Contact.Persistence.UnitOfWorks;

public class UnitOfWork : IUnitOfWork
{
    private readonly ContactDbContext _dbContext;

    public UnitOfWork(ContactDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void SaveChanges()
    {
        _dbContext.SaveChanges();
    }

    public Task<int> SaveChangesAsync()
    {
        return _dbContext.SaveChangesAsync();
    }
}