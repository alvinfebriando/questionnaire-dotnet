using MediatR;
using Microsoft.EntityFrameworkCore;
using Questionnaire.Application.Data;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Survey.Commands;

public class AddSurveyCommandHandler : IRequestHandler<AddSurveyCommand, SurveyResult>
{
    private readonly IApplicationDbContext _context;

    public AddSurveyCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<SurveyResult> Handle(
        AddSurveyCommand request,
        CancellationToken cancellationToken)
    {
        var questionIds = request.QuestionId.Select(
            questionId => new SurveyQuestion { SurveyId = questionId, QuestionId = questionId });
        var survey = new Domain.Entities.Survey
        {
            Date = request.Date,
            Lecturer = request.Lecturer,
            AspectCount = request.AspectCount,
            Place = request.Place,
            QuestionCount = request.QuestionCount,
            Subject = request.Subject,
            SurveyQuestions = questionIds.ToList()
        };
        _context.Surveys.Add(survey);
        await _context.SaveChangesAsync(cancellationToken);
        var _ = await _context.Surveys.Include(s => s.SurveyQuestions)
            .ThenInclude(sq => sq.Question)
            .FirstAsync(s => s.Id == survey.Id, cancellationToken);
        return new SurveyResult(
            survey.Id,
            survey.Place,
            survey.Date,
            survey.Subject,
            survey.Lecturer,
            survey.QuestionCount,
            survey.AspectCount,
            survey.SurveyQuestions);
    }
}