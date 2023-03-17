using MediatR;
using Questionnaire.Application.Common.Interfaces;

namespace Questionnaire.Application.Survey.Queries;

public class GetSurveyQueryHandler : IRequestHandler<GetSurveyQuery, IEnumerable<SurveyResult>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetSurveyQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<SurveyResult>> Handle(
        GetSurveyQuery request,
        CancellationToken cancellationToken)
    {
        var result = await _unitOfWork.SurveyRepository.All();
        return result.Select(
            r => new SurveyResult(
                r.Place,
                r.Date,
                r.Subject,
                r.Respondent,
                r.Lecturer,
                r.QuestionCount,
                r.AspectCount,
                r.SurveyQuestions
            ));
    }
}