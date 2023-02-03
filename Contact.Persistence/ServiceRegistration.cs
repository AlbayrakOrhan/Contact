using Contact.Application.Interfaces;
using Contact.Persistence.Context;
using Contact.Persistence.Repositories;
using Contact.Persistence.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Contact.Persistence;

public static class ServiceRegistration
{
    public static void Inject(IServiceCollection services)
    {
        services.AddDbContext<ContactDbContext>(options => options.UseNpgsql("Host=localhost;Port=54320;Username=postgres;Password=testdb;Database=Contact", x => x.MigrationsAssembly("Contact.Persistence")));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddScoped<IPersonContactRepository, PersonContactRepository>();
    }
}