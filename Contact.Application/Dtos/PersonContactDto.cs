using Contact.Domain.Enums;

namespace Contact.Application.Dtos;

public class PersonContactDto
{
    public Guid Id { get; set; }
    public ContactType ContactType { get; set; }
    public string Value { get; set; }
}