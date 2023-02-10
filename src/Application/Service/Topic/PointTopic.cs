using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Application.Service.Message;
using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Topic;

public class PointTopic : GenericTopic<PointDto>
{
    private readonly ILexicalization _lex;

    public PointTopic(Content content, Structure structure, ILexicalization lex) : base(content,
        structure)
    {
        _lex = lex;
    }

    public override IList<BaseMessage<PointDto>> Order()
    {
        Transform();
        var order = new List<BaseMessage<PointDto>>();
        if (IsGnG())
        {
            order.Add(GoodPoints[0]);
            order.Add(BadPoints[0]);
            order.Add(Details[0]);
            order.Add(Details[1]);

            return order;
        }

        order.Add(BadPoints[0]);
        order.Add(GoodPoints[0]);
        order.Add(Details[0]);
        order.Add(Details[1]);

        return order;
    }

    public override IList<string> Aggregate()
    {
        var order = Order();
        var output = new List<string>();
        if (IsGnG())
        {
            if (GoodPoints.Count > 1)
            {
                var message = (IMultiLexicalizationMessage)order[0];
                var averagedAnswers = GoodPoints.Select(p => p.Data.Answer).ToList();
                var s = message.Lexicalization(averagedAnswers);
                output.Add(s);
            }
            else
            {
                var s = order[0].Lexicalization();
                output.Add(s);
            }

            ((IComplemented)order[1]).EmbedComplement(new Option(Structure.Get(3)));

            if (BadPoints.Count > 1)
            {
                var message = (IMultiLexicalizationMessage)order[1];
                var averagedAnswers = BadPoints.Select(p => p.Data.Answer).ToList();
                var s = message.Lexicalization(averagedAnswers);
                output.Add(s);
            }
            else
            {
                var s = order[1].Lexicalization();
                output.Add(s);
            }
        }
        else
        {
            if (BadPoints.Count > 1)
            {
                var message = (IMultiLexicalizationMessage)order[0];
                var averagedAnswers = BadPoints.Select(p => p.Data.Answer).ToList();
                var s = message.Lexicalization(averagedAnswers);
                output.Add(s);
            }
            else
            {
                var s = order[0].Lexicalization();
                output.Add(s);
            }

            ((IComplemented)order[1]).EmbedComplement(new Option(Structure.Get(3)));

            if (GoodPoints.Count > 1)
            {
                var message = (IMultiLexicalizationMessage)order[1];
                var averagedAnswers = GoodPoints.Select(p => p.Data.Answer).ToList();
                var s = message.Lexicalization(averagedAnswers);
                output.Add(s);
            }
            else
            {
                var s = order[1].Lexicalization();
                output.Add(s);
            }
        }

        ((IComplemented)order[2]).EmbedComplement(new Option("max"));
        ((IComplemented)order[3]).EmbedComplement(new Option("min"));
        var detail1 = order[2].Lexicalization();
        var detail2 = order[3].Lexicalization();
        output.Add(detail1);
        output.Add(detail2);
        return output;
    }


    public IList<BaseMessage<PointDto>> GoodPoints = new List<BaseMessage<PointDto>>();
    public IList<BaseMessage<PointDto>> BadPoints = new List<BaseMessage<PointDto>>();
    public IList<BaseMessage<PointDto>> Details = new List<BaseMessage<PointDto>>();

    private void Transform()
    {
        if (Structure.Get("no good") > 0)
        {
            var dto = new PointDto(Content.Lecturer, Content.Point.Max);
            var message = new NoGoodPointMessage(dto, _lex);
            GoodPoints.Add(message);
        }

        if (Structure.Get("no bad") > 0)
        {
            var dto = new PointDto(Content.Lecturer, Content.Point.Min);
            var message = new NoBadPointMessage(dto, _lex);
            BadPoints.Add(message);
        }

        foreach (var item in Content.Point.Good)
        {
            var dto = new PointDto(Content.Lecturer, item);
            var message = new GoodPointMessage(dto, _lex);
            GoodPoints.Add(message);
        }

        foreach (var item in Content.Point.Bad)
        {
            var dto = new PointDto(Content.Lecturer, item);
            var message = new BadPointMessage(dto, _lex);
            BadPoints.Add(message);
        }

        var dto1 = new PointDto(Content.Lecturer, Content.Point.Max);
        var dto2 = new PointDto(Content.Lecturer, Content.Point.Min);
        var message1 = new DetailPointMessage(dto1, _lex);
        var message2 = new DetailPointMessage(dto2, _lex);
        Details.Add(message1);
        Details.Add(message2);
    }

    private bool IsGnG()
    {
        return new List<string> { "good", "no good" }.Contains(Structure.Get(3));
    }
}