using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Topic;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Service.MicroPlanning;

public class MicroPlanning : IMicroPlanning
{
    private readonly ILexicalization _lex;

    public MicroPlanning(Content content, Structure structure, ILexicalization lex)
    {
        Content = content;
        Structure = structure;
        _lex = lex;
    }

    public Content Content { get; set; }
    public Structure Structure { get; set; }

    public IEnumerable<BaseTopic> Create()
    {
        var overviewTopic = new OverviewTopic(Content, Structure, _lex);
        var openingTopic = new OpeningTopic(Content, Structure, _lex);
        var pointTopic = new PointTopic(Content, Structure, _lex);
        var adviceTopic = new AdviceTopic(Content, Structure, _lex);
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