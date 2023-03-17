using MediatR;
using Questionnaire.Application.Common.Interfaces;

namespace Questionnaire.Application.Questions.Queries;

public class QuestionQueryHandler : IRequestHandler<QuestionQuery, QuestionResult>
{
    private readonly IUnitOfWork _unitOfWork;

    public QuestionQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<QuestionResult> Handle(
        QuestionQuery request,
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        var questions = await _unitOfWork.QuestionRepository.All();
        return new QuestionResult(questions.Select(q => new QuestionData(q.Id, q.Title)));
    }
}