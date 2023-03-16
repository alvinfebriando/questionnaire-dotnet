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
        return new QuestionResult(_questionRepository.Questions.Select(q => q.Title));
    }
}