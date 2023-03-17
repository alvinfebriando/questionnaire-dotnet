using MediatR;
using Questionnaire.Application.Common.Interfaces;

namespace Questionnaire.Application.Questions.Queries;

public class QuestionQueryHandler : IRequestHandler<QuestionQuery, IEnumerable<QuestionResult>>
{
    private readonly IUnitOfWork _unitOfWork;

    public QuestionQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<QuestionResult>> Handle(
        QuestionQuery request,
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        var questions = await _unitOfWork.QuestionRepository.All();
        return questions.Select(q => new QuestionResult(q.Id, q.Title));
    }
}