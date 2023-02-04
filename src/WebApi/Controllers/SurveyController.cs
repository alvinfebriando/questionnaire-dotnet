using MediatR;
using Microsoft.AspNetCore.Mvc;
using Questionnaire.Application.Survey.Commands;
using Questionnaire.WebApi.Dto;

namespace Questionnaire.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SurveyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Submit([FromBody] SurveyRequest request)
        {
            var command = new SurveyCommand(request.Place,
                request.Date,
                request.Subject,
                request.Respondent,
                request.Lecturer,
                request.Score,
                request.QuestionCount,
                request.AspectCount,
                request.Answers);
            var r = await _mediator.Send(command);
            return Ok(string.Join("",r));
        }
    }
}