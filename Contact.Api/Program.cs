var builder = WebApplication.CreateBuilder(args);

Contact.Persistence.ServiceRegistration.Inject(builder.Services);
Contact.Application.ServiceRegistration.Inject(builder.Services);


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();