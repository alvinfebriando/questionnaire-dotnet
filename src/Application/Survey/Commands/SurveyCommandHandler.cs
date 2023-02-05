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

    public SurveyCommandHandler(ILexicalization lex, IQuestionProvider questionProvider)
    {
        _lex = lex;
        _questionProvider = questionProvider;
    }

    public async Task<IEnumerable<string>> Handle(SurveyCommand request,
        CancellationToken cancellationToken)
    {
        var answers = AnswerConverter.Convert(_questionProvider, request.Answers);
        var dPlan = new DocumentPlanning.DocumentPlanning();

        var contentRule = new ContentRule();
        var structureRule = new StructureRule();

        var content =
            dPlan.DetermineContent(request.Place,
                request.Date,
                request.Subject,
                request.Respondent,
                request.Lecturer,
                request.QuestionCount,
                request.AspectCount,
                answers,
                contentRule);
        var structure = dPlan.DetermineStructure(content.Point, structureRule);

        var mPlan = new MicroPlanning.MicroPlanning(content, structure, _lex);
        var topics = mPlan.Create();

        var realization = new Realization.Realization(topics);
        realization.AddFormatter(new CapitalSentenceFormatter());

        var paragraph = realization.LinguisticRealization();
        return paragraph;
    }
}