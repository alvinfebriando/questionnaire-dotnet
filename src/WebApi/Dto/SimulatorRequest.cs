namespace Questionnaire.WebApi.Dto;

public record SimulatorRequest(int RespondentCount, List<int> DominantScore);