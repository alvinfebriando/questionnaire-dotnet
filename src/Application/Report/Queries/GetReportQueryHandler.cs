using MediatR;
using Microsoft.EntityFrameworkCore;
using Questionnaire.Application.Data;
using Questionnaire.Application.Service.Report;

namespace Questionnaire.Application.Report.Queries;

public class GetReportQueryHandler : IRequestHandler<GetReportQuery, ReportResult>
{
    private readonly IApplicationDbContext _context;
    private readonly IReport _report;

    public GetReportQueryHandler(IApplicationDbContext context, IReport report)
    {
        _context = context;
        _report = report;
    }

    public async Task<ReportResult> Handle(GetReportQuery request, CancellationToken cancellationToken)
    {

        throw new NotImplementedException();
    }
}