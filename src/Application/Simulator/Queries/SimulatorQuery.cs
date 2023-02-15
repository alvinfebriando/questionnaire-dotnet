using MediatR;

namespace Questionnaire.Application.Simulator.Queries;

public record SimulatorQuery(int RespondentCount, List<int> DominantScores): IRequest<SimulatorResult>;