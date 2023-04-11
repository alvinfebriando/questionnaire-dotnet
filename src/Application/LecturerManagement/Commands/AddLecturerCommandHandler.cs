using MediatR;
using Questionnaire.Application.Data;

namespace Questionnaire.Application.LecturerManagement.Commands;

public class AddLecturerCommandHandler : IRequestHandler<AddLecturerCommand, LecturerResult>
{
    private readonly IApplicationDbContext _context;

    public AddLecturerCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<LecturerResult> Handle(
        AddLecturerCommand request,
        CancellationToken cancellationToken)
    {
        var lecturer = new Domain.Entities.Lecturer { Name = request.Name, Title = request.Title };
        _context.Lecturers.Add(lecturer);
        await _context.SaveChangesAsync(cancellationToken);
        return new LecturerResult(lecturer.Id, lecturer.Name, lecturer.Title);
    }
}