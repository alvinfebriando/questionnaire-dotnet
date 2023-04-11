namespace Questionnaire.Application.QuestionManagement;

public record AllQuestionResult(IEnumerable<QuestionResult> Questions);

public record QuestionResult(Guid Id, string Question);