using MediatR;

namespace Questionnaire.Application.AnswerManagement.Commands;

public record SimulateAnswerCommand(int N, IEnumerable<AnswerOfSurveyQuestion> Answers) : IRequest;