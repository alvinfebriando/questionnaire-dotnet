using MediatR;

namespace Questionnaire.Application.Answers.Queries;

public record GetAnswerBySurveyQuery(Guid SurveyId) : IRequest<AllAnswerResult>;