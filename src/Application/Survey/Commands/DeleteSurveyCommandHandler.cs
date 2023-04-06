using MediatR;
using Microsoft.EntityFrameworkCore;
using Questionnaire.Application.Data;

namespace Questionnaire.Application.Survey.Commands;

public class DeleteSurveyCommandHandler : IRequestHandler<DeleteSurveyCommand, Unit>
{
    private readonly IApplicationDbContext _context;

    public DeleteSurveyCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(DeleteSurveyCommand request, CancellationToken cancellationToken)
    {
        var survey = await _context.Surveys.FirstAsync(s => s.Id == request.Id, cancellationToken);
        _context.Surveys.Remove(survey);

        await _context.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}