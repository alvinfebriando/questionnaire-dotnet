using MediatR;
using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Survey.Commands;

public class AddSurveyCommandHandler : IRequestHandler<AddSurveyCommand, SurveyResult>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddSurveyCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<SurveyResult> Handle(
        AddSurveyCommand request,
        CancellationToken cancellationToken)
    {
        var id = Guid.NewGuid();
        var questionIds = request.QuestionId.Select(
            questionId => new SurveyQuestion { SurveyId = questionId, QuestionId = questionId });
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
        var _ = (await _unitOfWork.SurveyRepository.GetById(survey.Id)).SurveyQuestions.Select(
            sq => sq.Question);
        return new SurveyResult(
            survey.Id,
            survey.Place,
            survey.Date,
            survey.Subject,
            survey.Respondent,
            survey.Lecturer,
            survey.QuestionCount,
            survey.AspectCount,
            survey.SurveyQuestions);
    }
}