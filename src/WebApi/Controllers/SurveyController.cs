using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Questionnaire.Application.Survey;
using Questionnaire.Application.Survey.Commands;
using Questionnaire.Application.Survey.Queries;
using Questionnaire.WebApi.Dto;

namespace Questionnaire.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SurveyController:ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public SurveyController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var query = new GetSurveyQuery();
        var result = await _mediator.Send(query);
        var response = result.Select(r => _mapper.Map<SurveyResponse>(r));
        return Ok(response);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var query = new GetSurveyByIdQuery(id);
        var result = await _mediator.Send(query);
        return Ok(_mapper.Map<SurveyResponse>(result));
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] AddSurveyRequest request)
    {
        var command = _mapper.Map<AddSurveyCommand>(request);
        var result = await _mediator.Send(command);
        var response = _mapper.Map<SurveyResponse>(result);
        return Ok(response);
    }
}