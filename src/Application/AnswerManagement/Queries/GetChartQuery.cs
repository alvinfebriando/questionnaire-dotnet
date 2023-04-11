using MediatR;

namespace Questionnaire.Application.AnswerManagement.Queries;

public record GetChartQuery(Guid SurveyId) : IRequest<ChartResult>;