namespace Questionnaire.WebApi.Dto;

public record AllAnswerResponse(IEnumerable<AnswerResponse> Answers);
public record AnswerResponse(Guid Id, Guid SurveyId, Guid QuestionId, double Score);