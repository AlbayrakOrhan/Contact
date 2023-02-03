using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Contact.Domain.Enums;
using MediatR;

namespace Contact.Application.Commands.CreateNewContact;

public class CreateNewContactCommand : IRequest<CreateNewContactCommandResult>
{
    [JsonIgnore]  
    public Guid PersonId { get; set; }
    public ContactType Type { get; set; }
    public string Value { get; set; }
}