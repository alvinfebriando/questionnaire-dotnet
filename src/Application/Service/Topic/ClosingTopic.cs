using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Application.Service.Message;
using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Topic;

public class ClosingTopic : GenericTopic<CLosingDto>
{
    private readonly ILexicalization _lex;
    private readonly ITemplateProvider _templateProvider;

    public ClosingTopic(
        Content content,
        Structure structure,
        ILexicalization lex,
        ITemplateProvider templateProvider) : base(
        content,
        structure)
    {
        _lex = lex;
        _templateProvider = templateProvider;
    }

    public override IList<BaseMessage<CLosingDto>> Sort()
    {
        var messages = new List<BaseMessage<CLosingDto>>();
        if (Structure.Get("no advice") > 0)
        {
            var advices = Content.Point.Min.Answer.Select(a => a.SurveyQuestion.Question.Advice).ToList();
            var dto = new CLosingDto(Content.Lecturer, advices);
            var noAdviceMessage = new NoAdviceMessage(dto, _lex, _templateProvider);
            messages.Add(noAdviceMessage);
        }
        else
        {
            foreach (var answers in Content.Point.Bad)
            {
                var advices = answers.Answer.Select(a => a.SurveyQuestion.Question.Advice).ToList();
                var dto = new CLosingDto(Content.Lecturer, advices);
                var adviceMessage = new AdviceMessage(dto, _lex, _templateProvider);
                messages.Add(adviceMessage);
            }
        }

        return messages;
    }

    public override IList<Aggregated> Aggregate()
    {
        var order = Sort();
        var output = new List<Aggregated>();
        var s = "";
        if (order.Count <= 1)
        {
            s = order[0].EntitySlotting();
        }
        else
        {
            var advices = order.Select(m => m.Data.Advice)
                .Skip(1)
                .ToList();
            s = ((AdviceMessage)order[0]).EntitySlotting(advices);
        }

        output.Add(new Aggregated(order[0].Template, s));

        return output;
    }
}