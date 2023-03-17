using MediatR;
using Questionnaire.Application.Common.Interfaces;

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
        var survey = new Domain.Entities.Survey
        {
            Id=Guid.NewGuid(),
            
        };
        await _unitOfWork.SurveyRepository.Add(survey);
        return Unit.Value;
    }
}