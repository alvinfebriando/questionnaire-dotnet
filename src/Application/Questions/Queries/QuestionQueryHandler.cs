using MediatR;
using Questionnaire.Application.Common.Interfaces;

namespace Questionnaire.Application.Questions.Queries;

public class QuestionQueryHandler : IRequestHandler<QuestionQuery, QuestionResult>
{
    private readonly IQuestionRepository _questionRepository;

    public QuestionQueryHandler(IQuestionRepository questionRepository)
    {
        _questionRepository = questionRepository;
    }

    public async Task<QuestionResult> Handle(
        QuestionQuery request,
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        var questions = await _questionRepository.All();
        return new QuestionResult(questions.Select(q=>q.Title));
    }
}