using MediatR;

namespace Questionnaire.Application.Questions.Queries;

public record GetAllQuestionQuery : IRequest<AllQuestionResult>;