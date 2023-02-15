using MediatR;

namespace Questionnaire.Application.Simulator.Queries;

public record SimulatorQuery(): IRequest<SimulatorResult>;