using MediatR;

namespace Questionnaire.Application.Simulator.Queries;

public class SimulatorQueryHandler : IRequestHandler<SimulatorQuery, SimulatorResult>
{
    public Task<SimulatorResult> Handle(SimulatorQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}