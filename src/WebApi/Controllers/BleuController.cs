using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Questionnaire.Application.BleuScore.Queries;
using Questionnaire.Application.Survey.Commands;
using Questionnaire.WebApi.Dto;

namespace Questionnaire.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BleuController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public BleuController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    public async Task<IActionResult> Submit([FromBody] BleuRequest request)
    {
        var command = _mapper.Map<BleuQuery>(request);
        var r = await _mediator.Send(command);
        return Ok(r);
    }
}