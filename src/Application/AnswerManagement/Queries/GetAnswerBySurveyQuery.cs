using MediatR;

namespace Questionnaire.Application.AnswerManagement.Queries;

public record GetAnswerBySurveyQuery(Guid SurveyId) : IRequest<AllAnswerResult>;