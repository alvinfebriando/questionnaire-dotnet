using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Questionnaire.Application.SurveyManagement.Commands;
using Questionnaire.Application.SurveyManagement.Queries;
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
        var response = _mapper.Map<AllSurveyResponse>(result);
        return Ok(response);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var query = new GetSurveyByIdQuery(id);
        var result = await _mediator.Send(query);
        var response = _mapper.Map<SurveyResponse>(result);
        return Ok(response);
    }

    [Authorize("AdminOnly")]
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] AddSurveyRequest request)
    {
        var command = _mapper.Map<AddSurveyCommand>(request);
        var result = await _mediator.Send(command);
        var response = _mapper.Map<SurveyResponse>(result);
        return CreatedAtAction(nameof(GetById), new { id = result.Id }, response);
    }

    [Authorize("AdminOnly")]
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var command = new DeleteSurveyCommand(id);
        await _mediator.Send(command);
        return NoContent();
    }
}