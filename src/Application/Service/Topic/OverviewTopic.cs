using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Application.Service.Message;
using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Topic;

public class OverviewTopic : GenericTopic<OverviewDto>
{
    private readonly ILexicalization _lex;
    private readonly ITemplateProvider _templateProvider;

    public OverviewTopic(
        Content content,
        Structure structure,
        ILexicalization lex,
        ITemplateProvider templateProvider) : base(content, structure)
    {
        OverviewDto = new OverviewDto(
            Content.Lecturer,
            Content.AverageScore,
            Content.QuestionCount,
            Content.AspectCount);
        _lex = lex;
        _templateProvider = templateProvider;
    }

    public OverviewDto OverviewDto { get; init; }

    public override IList<BaseMessage<OverviewDto>> Order()
    {
        var averageScoreMsg = new AverageScoreMessage(OverviewDto, _lex, _templateProvider);
        var performanceMsg = new PerformanceStatusMessage(OverviewDto, _lex, _templateProvider);
        return Structure.Get(1) == "score"
            ? new List<BaseMessage<OverviewDto>> { averageScoreMsg, performanceMsg }
            : new List<BaseMessage<OverviewDto>> { performanceMsg, averageScoreMsg };
    }

    public override IList<string> Aggregate()
    {
        var order = Order();
        if (Structure.Get(1) == "score")
        {
            ((IComplemented)order[0]).EmbedComplement(new Option("first"));
            ((IComplemented)order[1]).EmbedComplement(new Option("second"));
        }
        else
        {
            ((IComplemented)order[1]).EmbedComplement(new Option("second"));
        }

        return order.Select(message => message.EntitySlotting()).ToList();
    }
}