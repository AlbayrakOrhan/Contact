using Contact.Application.Commands.CreateNewContact;
using Contact.Application.Commands.CreateNewPerson;
using Contact.Application.Commands.DeleteContact;
using Contact.Application.Commands.DeletePerson;
using Contact.Application.Queries.GetPersonDetail;
using Contact.Application.Queries.ListPerson;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Contact.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonsController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<PersonsController> _logger;

    public PersonsController(ILogger<PersonsController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] CreateNewPersonCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpDelete("{id:guid}")]
    public async Task<ActionResult> Delete(Guid id)
    {
        return Ok(await _mediator.Send(new DeletePersonCommand()
        {
            Id = id
        }));
    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        return Ok(await _mediator.Send(new ListPersonQuery()));
    }

    [HttpGet("{id:guid}/details")]
    public async Task<ActionResult> Get(Guid id)
    {
        return Ok(await _mediator.Send(new GetPersonDetailQuery()
        {
            Id = id
        }));
    }

    [HttpPost("{id:guid}/contacts")]
    public async Task<ActionResult> Post(Guid id, [FromBody] CreateNewContactCommand command)
    {
        command.PersonId = id;
        return Ok(await _mediator.Send(command));
    }

    [HttpDelete("{personId:guid}/contacts/{contactId:guid}")]
    public async Task<ActionResult> Delete(Guid personId, Guid contactId)
    {
        return Ok(await _mediator.Send(new DeleteContactCommand()
        {
            PersonId = personId,
            ContactId = contactId
        }));
    }
}