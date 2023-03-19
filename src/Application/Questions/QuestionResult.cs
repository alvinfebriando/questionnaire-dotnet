namespace Questionnaire.Application.Questions;

public record AllQuestionResult(IEnumerable<QuestionResult> Questions);

public record QuestionResult(Guid Id, string Question);