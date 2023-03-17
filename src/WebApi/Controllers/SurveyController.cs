using Microsoft.AspNetCore.Mvc;
using Questionnaire.WebApi.Dto;

namespace Questionnaire.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SurveyController:ControllerBase
{
    [HttpGet]
    public Task<IActionResult> Get()
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id:guid}")]
    public Task<IActionResult> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public Task<IActionResult> Post([FromBody] SurveyRequest request)
    {
        throw new NotImplementedException();
    }
}