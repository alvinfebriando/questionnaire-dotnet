using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Questionnaire.Application.Lecturer.Commands;
using Questionnaire.Application.Lecturer.Queries;
using Questionnaire.WebApi.Dto;

namespace Questionnaire.WebApi.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class LecturerController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public LecturerController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var query = new GetAllLecturerQuery();
        var result = await _mediator.Send(query);
        var response = _mapper.Map<AllLecturerResponse>(result);
        return Ok(response);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var query = new GetLecturerByIdQuery(id);
        var result = await _mediator.Send(query);
        var response = _mapper.Map<LecturerResponse>(result);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] AddLecturerRequest request)
    {
        var command = _mapper.Map<AddLecturerCommand>(request);
        var result = await _mediator.Send(command);
        var response = _mapper.Map<LecturerResponse>(result);
        return CreatedAtAction(nameof(GetById), new { id = result.Id }, response);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var command = new DeleteLecturerCommand(id);
        await _mediator.Send(command);
        return NoContent();
    }
}