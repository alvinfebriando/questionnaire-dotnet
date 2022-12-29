using Questionnaire.Application.Dto;
using Questionnaire.Application.Message;
using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Topic;

public class OverviewTopic : BaseTopic<OverviewDto>
{
    private readonly ILexicalization _lex;

    public OverviewTopic(Content content, Structure structure,
        ILexicalization lex) : base(content, structure)
    {
        OverviewDto = new OverviewDto(Content.Lecturer, Content.AverageScore);
        _lex = lex;
    }

    public OverviewDto OverviewDto { get; init; }

    public override IList<BaseMessage<OverviewDto>> Order()
    {
        var averageScoreMsg = new AverageScoreMessage(OverviewDto, _lex);
        var performanceMsg = new PerformanceStatusMessage(OverviewDto, _lex);
        return Structure.Get(0) == "score"
            ? new List<BaseMessage<OverviewDto>>
                { averageScoreMsg, performanceMsg }
            : new List<BaseMessage<OverviewDto>>
                { performanceMsg, averageScoreMsg };
    }

    public override IList<string> Aggregate()
    {
        var order = Order();
        if (Structure.Get(0) == "score")
        {
            ((IComplemented)order[0]).EmbedComplement(new Option("first"));
            ((IComplemented)order[1]).EmbedComplement(new Option("second"));
        }
        else
        {
            ((IComplemented)order[1]).EmbedComplement(new Option("second"));
        }

        return order.Select(message => message.Lexicalization()).ToList();
    }
}