namespace Questionnaire.Application.Questions;

public record QuestionResult(IEnumerable<QuestionData> Questions);

public record QuestionData(Guid Id, string Question);