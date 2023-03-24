using MediatR;

namespace Questionnaire.Application.Survey.Queries;

public record GetSurveyQuery() : IRequest<AllSurveyResult>;
