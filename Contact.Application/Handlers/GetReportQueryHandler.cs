using Contact.Application.Interfaces;
using Contact.Application.Queries.GetReport;
using MediatR;

namespace Contact.Application.Handlers;

public class GetReportQueryHandler : IRequestHandler<GetReportQuery, GetReportQueryResult>
{
    private readonly IReportAssembler _reportAssembler;

    public GetReportQueryHandler(IReportAssembler reportAssembler)
    {
        _reportAssembler = reportAssembler;
    }

    public async Task<GetReportQueryResult> Handle(GetReportQuery request, CancellationToken cancellationToken)
    {
        await Task.Delay(5000, cancellationToken);
        return _reportAssembler.MapToGetReportQueryResult();
    }
}