namespace Questionnaire.Application.AnswerManagement;

public record AllAnswerResult(IEnumerable<AnswerResult> Answers);
public record AnswerResult(Guid Id, Guid SurveyId, Guid QuestionId, double Score);