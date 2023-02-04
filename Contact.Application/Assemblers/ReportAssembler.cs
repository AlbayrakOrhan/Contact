using Contact.Application.Commands.CreateNewPerson;
using Contact.Application.Dtos;
using Contact.Application.Interfaces;
using Contact.Application.Queries.GetPersonDetail;
using Contact.Application.Queries.GetReport;
using Contact.Application.Queries.ListPerson;
using Contact.Domain.Entities;

namespace Contact.Application.Assemblers;

public class ReportAssembler : IReportAssembler
{
    public GetReportQueryResult MapToGetReportQueryResult()
    {
        return new GetReportQueryResult()
        {
            ReportData = new List<LocationReportDto>()
            {
                new (){Location = "test",PersonCount = 1000,PhoneNumberCount = 1500}
            }
        };
    }
}