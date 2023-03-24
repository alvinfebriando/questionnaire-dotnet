using MediatR;
using Questionnaire.Application.Common.Interfaces;

namespace Questionnaire.Application.Survey.Queries;

public class GetSurveyQueryHandler : IRequestHandler<GetSurveyQuery, AllSurveyResult>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetSurveyQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<AllSurveyResult> Handle(
        GetSurveyQuery request,
        CancellationToken cancellationToken)
    {
        var result = await _unitOfWork.SurveyRepository.All();
        return new AllSurveyResult(
            result.Select(
                r => new SurveyResult(
                    r.Id,
                    r.Place,
                    r.Date,
                    r.Subject,
                    r.Respondent,
                    r.Lecturer,
                    r.QuestionCount,
                    r.AspectCount,
                    r.SurveyQuestions
                )));
    }
}