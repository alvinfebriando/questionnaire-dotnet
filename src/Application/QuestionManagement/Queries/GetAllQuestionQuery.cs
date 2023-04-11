using MediatR;

namespace Questionnaire.Application.QuestionManagement.Queries;

public record GetAllQuestionQuery : IRequest<AllQuestionResult>;