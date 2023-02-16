using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Questionnaire.Application.Simulator.Queries;
using Questionnaire.WebApi.Dto;

namespace Questionnaire.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SimulatorController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public SimulatorController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> A([FromBody] SimulatorRequest request)
    {
        var query = _mapper.Map<SimulatorQuery>(request);
        var simResult = await _mediator.Send(query);
        return Ok(_mapper.Map<SimulatorResponse>(simResult));
    }
}