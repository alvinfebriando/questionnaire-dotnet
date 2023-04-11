using MediatR;
using Microsoft.EntityFrameworkCore;
using Questionnaire.Application.Data;

namespace Questionnaire.Application.LecturerManagement.Queries;

public class
    GetAllLecturerQueryHandler : IRequestHandler<GetAllLecturerQuery, AllLecturerResult>
{
    private readonly IApplicationDbContext _context;

    public GetAllLecturerQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<AllLecturerResult> Handle(
        GetAllLecturerQuery request,
        CancellationToken cancellationToken)
    {
        var lecturers = await _context.Lecturers.ToListAsync(cancellationToken);
        return new AllLecturerResult(
            lecturers.Select(l => new LecturerResult(l.Id, l.Name, l.Title)));
    }
}