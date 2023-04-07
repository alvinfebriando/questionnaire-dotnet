using MediatR;

namespace Questionnaire.Application.Answers.Commands;

public record SimulateAnswerCommand(int N, IEnumerable<AnswerOfSurveyQuestion> Answers) : IRequest;