namespace Contact.Application.Interfaces;

public interface IUnitOfWork
{
    void SaveChanges();
    Task<int> SaveChangesAsync();
}