using MediatR;
using Questionnaire.Application.Common.Interfaces;

namespace Questionnaire.Application.Survey.Commands;

public class AddSurveyCommandHandler : IRequestHandler<AddSurveyCommand, Unit>
{
    private readonly ISurveyRepository _surveyRepository;

    public AddSurveyCommandHandler(ISurveyRepository surveyRepository)
    {
        _surveyRepository = surveyRepository;
    }

    public async Task<Unit> Handle(AddSurveyCommand request, CancellationToken cancellationToken)
    {
        var survey = new Domain.Entities.Survey
        {
            Id=Guid.NewGuid(),
            
        };
        await _surveyRepository.Add(survey);
        return Unit.Value;
    }
}