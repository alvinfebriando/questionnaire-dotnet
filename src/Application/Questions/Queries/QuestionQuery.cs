using MediatR;

namespace Questionnaire.Application.Questions.Queries;

public record QuestionQuery : IRequest<IEnumerable<QuestionResult>>;