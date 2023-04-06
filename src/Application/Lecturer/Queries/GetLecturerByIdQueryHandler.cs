using MediatR;
using Questionnaire.Application.Data;

namespace Questionnaire.Application.Lecturer.Queries;

public class GetLecturerByIdQueryHandler : IRequestHandler<GetLecturerByIdQuery, LecturerResult>
{
    private readonly IApplicationDbContext _context;

    public GetLecturerByIdQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<LecturerResult> Handle(GetLecturerByIdQuery request, CancellationToken cancellationToken)
    {
        var lecturer = await _context.Lecturers.FindAsync(new object?[] { request.id }, cancellationToken: cancellationToken);
        return new LecturerResult(lecturer.Id, lecturer.Name, lecturer.Title);
    }
}