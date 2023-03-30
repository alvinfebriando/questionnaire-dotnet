using MediatR;
using Microsoft.EntityFrameworkCore;
using Questionnaire.Application.Data;
using Questionnaire.Application.Service.Report;

namespace Questionnaire.Application.Report.Queries;

public class GetReportQueryHandler : IRequestHandler<GetReportQuery, string>
{
    private readonly IApplicationDbContext _context;
    private readonly IReport _report;

    public GetReportQueryHandler(IApplicationDbContext context, IReport report)
    {
        _context = context;
        _report = report;
    }

    public async Task<string> Handle(GetReportQuery request, CancellationToken cancellationToken)
    {

        throw new NotImplementedException();
    }
}