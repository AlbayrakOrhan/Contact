using Contact.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Contact.Persistence;

public static class ServiceRegistration
{
    public static void Inject(IServiceCollection services)
    {
        services.AddDbContext<ContactDbContext>(options => options.UseNpgsql("Host=localhost;Port=54320;Username=postgres;Password=testdb;Database=Contact", x => x.MigrationsAssembly("Contact.Persistence")));
    }
}