using MediatR;

namespace Questionnaire.Application.Survey.Queries;

public record GetSurveyByIdQuery(Guid Id) : IRequest<SurveyResult>;