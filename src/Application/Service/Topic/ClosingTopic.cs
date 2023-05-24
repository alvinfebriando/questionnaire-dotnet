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
        CLosingDto dto = null!;
        
        if (Structure.Get("no advice") > 0)
        {
            var advices = Content.Point.Min.Answer.Select(a => a.SurveyQuestion.Question.Advice).ToList();
            dto = new CLosingDto(Content.Lecturer, Content.Subject, advices);
            var noAdviceMessage = new NoAdviceMessage(dto, _lex, _templateProvider);
            messages.Add(noAdviceMessage);
        }
        else
        {
            foreach (var answers in Content.Point.Bad)
            {
                var advices = answers.Answer.Select(a => a.SurveyQuestion.Question.Advice).ToList();
                dto = new CLosingDto(Content.Lecturer, Content.Subject, advices);
                var adviceMessage = new AdviceMessage(dto, _lex, _templateProvider);
                messages.Add(adviceMessage);
            }
        }

        var closingMessage = new ClosingMessage(dto, _lex, _templateProvider);
        messages.Add(closingMessage);

        return messages;
    }

    public override IList<Aggregated> Aggregate()
    {
        var order = Sort();
        var output = new List<Aggregated>();
        var s = "";
        if (order.Count <= 2)
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
        output.Add(new Aggregated(order[^1].Template, order[^1].EntitySlotting()));

        return output;
    }
}