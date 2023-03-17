using MediatR;

namespace Questionnaire.Application.Survey.Queries;

public class GetSurveyQueryHandler  : IRequestHandler<GetSurveyQuery, SurveyResult>
{
    public async Task<SurveyResult> Handle(GetSurveyQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}