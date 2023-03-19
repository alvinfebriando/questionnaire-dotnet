using MediatR;
using Questionnaire.Application.Common.Interfaces;

namespace Questionnaire.Application.Questions.Queries;

public class GetQuestionQueryHandler : IRequestHandler<GetAllQuestionQuery, AllQuestionResult>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetQuestionQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<AllQuestionResult> Handle(
        GetAllQuestionQuery request,
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        var questions = await _unitOfWork.QuestionRepository.All();
        var questionResults = questions.Select(q => new QuestionResult(q.Id, q.Title));
        return new AllQuestionResult(questionResults);
    }
}