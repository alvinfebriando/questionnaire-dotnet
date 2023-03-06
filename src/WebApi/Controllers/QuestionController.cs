using MediatR;
using Microsoft.AspNetCore.Mvc;
using Questionnaire.Application.Questions.Queries;

namespace Questionnaire.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class QuestionController : ControllerBase
{
    private readonly IMediator _mediator;

    public QuestionController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        var query = new QuestionQuery();
        var result = await _mediator.Send(query);
        return Ok(result);
    }
}