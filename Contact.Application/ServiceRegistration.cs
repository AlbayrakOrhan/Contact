using System.Reflection;
using Contact.Application.Behaviors;
using Contact.Application.Middlewares;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Contact.Application;

public static class ServiceRegistration
{
    public static void Inject(IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        services.AddTransient<ExceptionHandlingMiddleware>();
    }
}