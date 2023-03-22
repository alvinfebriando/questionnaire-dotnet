using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Questionnaire.Application.Answers.Commands;
using Questionnaire.WebApi.Dto;

namespace Questionnaire.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AnswerController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public AnswerController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Add(AddAnswerRequest request)
    {
        var command = _mapper.Map<AddAnswerCommand>(request);
        await _mediator.Send(command);
        return Ok();
    }
}