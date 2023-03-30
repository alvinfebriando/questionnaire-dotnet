namespace Questionnaire.Application.Answers;

public record AllAnswerResult(IEnumerable<AnswerResult> Answers);
public record AnswerResult(Guid Id, Guid SurveyId, Guid QuestionId, double Score);