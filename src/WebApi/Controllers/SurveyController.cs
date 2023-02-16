using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Questionnaire.Application.Survey.Commands;
using Questionnaire.WebApi.Dto;

namespace Questionnaire.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SurveyController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public SurveyController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> Submit([FromBody] SurveyRequest request)
    {
        var command = _mapper.Map<SurveyCommand>(request);
        var r = await _mediator.Send(command);
        return Ok(string.Join("", r));
    }
}