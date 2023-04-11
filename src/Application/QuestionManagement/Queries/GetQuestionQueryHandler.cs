using MediatR;
using Microsoft.EntityFrameworkCore;
using Questionnaire.Application.Data;

namespace Questionnaire.Application.QuestionManagement.Queries;

public class GetQuestionQueryHandler : IRequestHandler<GetAllQuestionQuery, AllQuestionResult>
{
    private readonly IApplicationDbContext _context;

    public GetQuestionQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<AllQuestionResult> Handle(
        GetAllQuestionQuery request,
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        var questions = await _context.Questions.ToListAsync(cancellationToken);
        var questionResults = questions.Select(q => new QuestionResult(q.Id, q.Title));
        return new AllQuestionResult(questionResults);
    }
}