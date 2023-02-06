using MediatR;
using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Lexicalization;
using Questionnaire.Application.Realization;
using Questionnaire.Application.Rule;

namespace Questionnaire.Application.Survey.Commands;

public class SurveyCommandHandler : IRequestHandler<SurveyCommand, IEnumerable<string>>
{
    private readonly ILexicalization _lex;
    private readonly IQuestionProvider _questionProvider;
    private readonly IContentRule _contentRule;
    private readonly IStructureRule _structureRule;

    public SurveyCommandHandler(ILexicalization lex,
        IQuestionProvider questionProvider,
        IContentRule contentRule,
        IStructureRule structureRule)
    {
        _lex = lex;
        _questionProvider = questionProvider;
        _contentRule = contentRule;
        _structureRule = structureRule;
    }

    public async Task<IEnumerable<string>> Handle(SurveyCommand request,
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        var answers = AnswerConverter.Convert(_questionProvider, request.Answers);
        var dPlan = new DocumentPlanning.DocumentPlanning();

        var content = dPlan.DetermineContent(request.Place,
            request.Date,
            request.Subject,
            request.Respondent,
            request.Lecturer,
            request.QuestionCount,
            request.AspectCount,
            answers,
            _contentRule);
        var structure = dPlan.DetermineStructure(content.Point, _structureRule);

        var mPlan = new MicroPlanning.MicroPlanning(content, structure, _lex);
        var topics = mPlan.Create();

        var realization = new Realization.Realization(topics);
        realization.AddFormatter(new CapitalSentenceFormatter());

        var paragraph = realization.LinguisticRealization();
        return paragraph;
    }
}