using MediatR;
using Questionnaire.Application.Common.Interfaces;

namespace Questionnaire.Application.Survey.Queries;

public class GetSurveyQueryHandler  : IRequestHandler<GetSurveyQuery, SurveyResult>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetSurveyQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<SurveyResult> Handle(GetSurveyQuery request, CancellationToken cancellationToken)
    {
        var result = await _unitOfWork.SurveyRepository.All();
        return new SurveyResult(result);
    }
}