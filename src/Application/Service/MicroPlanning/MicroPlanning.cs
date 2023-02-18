using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Topic;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Service.MicroPlanning;

public class MicroPlanning : IMicroPlanning
{
    private readonly ILexicalization _lex;
    private readonly ITemplateProvider _templateProvider;

    public MicroPlanning(ILexicalization lex, ITemplateProvider templateProvider)
    {
        _lex = lex;
        _templateProvider = templateProvider;
    }

    public void Init(Content content, Structure structure)
    {
        Content = content;
        Structure = structure;
    }

    public Content Content { get; set; }
    public Structure Structure { get; set; }

    public IEnumerable<BaseTopic> Create()
    {
        var overviewTopic = new OverviewTopic(Content, Structure, _lex, _templateProvider);
        var openingTopic = new OpeningTopic(Content, Structure, _lex, _templateProvider);
        var pointTopic = new PointTopic(Content, Structure, _lex, _templateProvider);
        var adviceTopic = new AdviceTopic(Content, Structure, _lex, _templateProvider);
        var list = new List<BaseTopic>
        {
            openingTopic,
            overviewTopic,
            pointTopic,
            adviceTopic
        };
        return list;
    }
}