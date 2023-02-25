using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Application.Service.Message;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Service.Topic;

public class OpeningTopic : GenericTopic<OpeningDto>
{
    private readonly ILexicalization _lex;
    private readonly ITemplateProvider _templateProvider;

    public OpeningTopic(
        Content content,
        Structure structure,
        ILexicalization lex,
        ITemplateProvider templateProvider) : base(
        content,
        structure)
    {
        OpeningDto =
            new OpeningDto(
                Content.Place,
                Content.Date,
                Content.Subject,
                Content.Respondent);
        _lex = lex;
        _templateProvider = templateProvider;
    }

    public OpeningDto OpeningDto { get; set; }

    public override IList<BaseMessage<OpeningDto>> Order()
    {
        var openingMsg = new OpeningMessage(OpeningDto, _lex, _templateProvider);
        return new List<BaseMessage<OpeningDto>> { openingMsg };
    }

    public override IList<string> Aggregate()
    {
        var order = Order();
        return order.Select(message => message.EntitySlotting()).ToList();
    }
}