using MediatR;
using Questionnaire.Application.Common.Interfaces;

namespace Questionnaire.Application.Survey.Queries;

public class GetSurveyByIdQueryHandler : IRequestHandler<GetSurveyByIdQuery, SurveyResult>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetSurveyByIdQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<SurveyResult> Handle(
        GetSurveyByIdQuery request,
        CancellationToken cancellationToken)
    {
        var result = await _unitOfWork.SurveyRepository.GetById(request.Id);
        return new SurveyResult(
            result.Id,
            result.Place,
            result.Date,
            result.Subject,
            result.Respondent,
            result.Lecturer,
            result.QuestionCount,
            result.AspectCount,
            result.SurveyQuestions);
    }
}