using Questionnaire.Domain.Entities;

namespace Questionnaire.WebApi.Dto;

public record SurveyResponse(IEnumerable<Survey> Surveys);