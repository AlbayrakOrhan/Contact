using Contact.Application.Abstracts;
using Contact.Application.Dtos;

namespace Contact.Application.Queries.GetReport;

public class GetReportQueryResult : ResponseBase
{
    public GetReportQueryResult()
    {
        ReportData = new List<LocationReportDto>();
    }

    public List<LocationReportDto> ReportData { get; set; }
}