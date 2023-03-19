namespace Questionnaire.WebApi.Dto;

public record AllQuestionResponse(IEnumerable<QuestionResponse> Questions);

public record QuestionResponse(Guid Id, string Question);