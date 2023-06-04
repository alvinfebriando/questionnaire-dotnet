using MediatR;
using Questionnaire.Application.Data;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.AnswerManagement.Commands;

public class AddAnswerCommandHandler : IRequestHandler<AddAnswerCommand, Unit>
{
    private readonly IApplicationDbContext _context;

    public AddAnswerCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(AddAnswerCommand request, CancellationToken cancellationToken)
    {
        var user = await _context.Users.FindAsync(new object?[] { request.AnsweredByUserId }, cancellationToken: cancellationToken);
        foreach (var answer in request.Answers)
        {
            var surveyQuestion = new SurveyQuestion
            {
                SurveyId = answer.SurveyId, QuestionId = answer.QuestionId
            };
            _context.SurveyQuestions.Attach(surveyQuestion);
            var a = new Answer
            {
                Score = answer.Score,
                SurveyQuestion = surveyQuestion,
                AnsweredByUser = user
            };
            _context.Answers.Add(a);
        }

        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}