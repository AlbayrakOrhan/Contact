using Contact.Application.Queries.GetReport;

namespace Contact.Application.Interfaces;

public interface IReportAssembler
{
    GetReportQueryResult MapToGetReportQueryResult();
}