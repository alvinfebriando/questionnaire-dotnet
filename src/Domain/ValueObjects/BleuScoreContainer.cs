namespace Questionnaire.Domain.ValueObjects;

public record BleuScoreContainer(string Template, string Candidate, double Score);