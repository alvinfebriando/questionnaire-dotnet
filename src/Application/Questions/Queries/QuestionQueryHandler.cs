using MediatR;
using Questionnaire.Application.Common.Interfaces;

namespace Questionnaire.Application.Questions.Queries;

public class QuestionQueryHandler:IRequestHandler<QuestionQuery, QuestionResult>
{
    private readonly IQuestionProvider _questionProvider;

    public QuestionQueryHandler(IQuestionProvider questionProvider)
    {
        _questionProvider = questionProvider;
    }

    public async Task<QuestionResult> Handle(QuestionQuery request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        return new QuestionResult(_questionProvider.Questions.Select(q=>q.Title));
    }
}