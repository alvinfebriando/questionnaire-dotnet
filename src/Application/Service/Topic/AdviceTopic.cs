using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Application.Service.Message;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Service.Topic;

public class AdviceTopic : GenericTopic<AdviceDto>
{
    private readonly ILexicalization _lex;

    public AdviceTopic(Content content, Structure structure, ILexicalization lex) : base(
        content,
        structure)
    {
        _lex = lex;
    }

    public override IList<BaseMessage<AdviceDto>> Order()
    {
        var messages = new List<BaseMessage<AdviceDto>>();
        if (Structure.Get("no advice") > 0)
        {
            var advices = Content.Point.Min.Answer.Select(a => a.Question.Advice).ToList();
            var dto = new AdviceDto(Content.Lecturer, advices);
            var noAdviceMessage = new NoAdviceMessage(dto, _lex);
            messages.Add(noAdviceMessage);
        }
        else
        {
            foreach (var answers in Content.Point.Bad)
            {
                var advices = answers.Answer.Select(a => a.Question.Advice).ToList();
                var dto = new AdviceDto(Content.Lecturer, advices);
                var adviceMessage = new AdviceMessage(dto, _lex);
                messages.Add(adviceMessage);
            }
        }

        return messages;
    }

    public override IList<string> Aggregate()
    {
        var order = Order();
        var output = new List<string>();
        if (order.Count <= 1)
        {
            var s = order[0].Lexicalization();
            output.Add(s);
        }
        else
        {
            var advices = order.Select(m => m.Data.Advice)
                .Skip(1)
                .ToList();
            var s = ((AdviceMessage)order[0]).Lexicalization(advices);
            output.Add(s);
        }

        return output;
    }
}