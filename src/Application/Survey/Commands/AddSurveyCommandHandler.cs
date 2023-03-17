using MediatR;
using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Survey.Commands;

public class AddSurveyCommandHandler : IRequestHandler<AddSurveyCommand, Unit>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddSurveyCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Unit> Handle(AddSurveyCommand request, CancellationToken cancellationToken)
    {
        var id = Guid.NewGuid();
        var questionIds = request.QuestionId.Select(questionId => new SurveyQuestion
        {
            SurveyId = questionId,
            QuestionId = questionId
        });
        var survey = new Domain.Entities.Survey
        {
            Id = id,
            Date = request.Date,
            Lecturer = request.Lecturer,
            AspectCount = request.AspectCount,
            Place = request.Place,
            QuestionCount = request.QuestionCount,
            Respondent = request.Respondent,
            Subject = request.Subject,
            SurveyQuestions = questionIds.ToList()
        };
        await _unitOfWork.SurveyRepository.Add(survey);
        await _unitOfWork.SaveChangesAsync();
        return Unit.Value;
    }
}