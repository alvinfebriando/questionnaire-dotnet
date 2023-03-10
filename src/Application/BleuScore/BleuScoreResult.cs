using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.BleuScore;

public record BleuScoreResult(List<BleuScoreContainer> Scores);