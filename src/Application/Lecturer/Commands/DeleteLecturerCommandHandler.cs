using MediatR;
using Questionnaire.Application.Data;

namespace Questionnaire.Application.Lecturer.Commands;

public class DeleteLecturerCommandHandler : IRequestHandler<DeleteLecturerCommand>
{
    private readonly IApplicationDbContext _context;

    public DeleteLecturerCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(
        DeleteLecturerCommand request,
        CancellationToken cancellationToken)
    {
        var lecturer = await _context.Lecturers.FindAsync(new object?[] { request.id }, cancellationToken);
        _context.Lecturers.Remove(lecturer);

        await _context.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}