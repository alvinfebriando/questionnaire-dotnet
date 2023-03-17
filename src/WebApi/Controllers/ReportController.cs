using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Questionnaire.Application.Report.Commands;
using Questionnaire.WebApi.Dto;

namespace Questionnaire.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReportController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public ReportController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> Submit([FromBody] ReportRequest request)
    {
        var command = _mapper.Map<ReportCommand>(request);
        var r = await _mediator.Send(command);
        return Ok(r);
    }
}