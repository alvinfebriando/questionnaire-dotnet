﻿using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Questionnaire.Application.AnswerManagement.Commands;
using Questionnaire.Application.AnswerManagement.Queries;
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

    [HttpGet("{surveyId:guid}")]
    public async Task<IActionResult> Get(Guid surveyId)
    {
        var query = new GetAnswerBySurveyQuery(surveyId);
        var result = await _mediator.Send(query);
        var response = _mapper.Map<AllAnswerResponse>(result);
        return Ok(response);
    }
    [Authorize("AdminOnly")]
    [HttpGet("{surveyId:guid}/chart")]
    public async Task<IActionResult> GetChartData(Guid surveyId)
    {
        var query = new GetChartQuery(surveyId);
        var result = await _mediator.Send(query);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Add(AddAnswerRequest request)
    {
        var command = _mapper.Map<AddAnswerCommand>(request);
        await _mediator.Send(command);
        return StatusCode(201);
    }
    
    [Authorize("AdminOnly")]
    [HttpPost("simulate")]
    public async Task<IActionResult> BulkAdd(SimulateAnswerRequest request)
    {
        var command = _mapper.Map<SimulateAnswerCommand>(request);
        await _mediator.Send(command);
        return StatusCode(201);
    }
}