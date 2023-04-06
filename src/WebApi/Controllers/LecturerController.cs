using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
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
}