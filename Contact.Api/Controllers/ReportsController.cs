using Contact.Application.Queries.GetReport;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Contact.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ReportsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ReportsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        return Ok(await _mediator.Send(new GetReportQuery()));
    }
}