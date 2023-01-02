using Questionnaire.Application.Dto;
using Questionnaire.Application.Message;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Topic;

public class OpeningTopic : GenericTopic<OpeningDto>
{
    private readonly ILexicalization _lex;

    public OpeningTopic(Content content, Structure structure, ILexicalization lex) : base(content,
        structure)
    {
        OpeningDto =
            new OpeningDto(Content.Place, Content.Date, Content.Subject, Content.Respondent);
        _lex = lex;
    }

    public OpeningDto OpeningDto { get; set; }

    public override IList<BaseMessage<OpeningDto>> Order()
    {
        var openingMsg = new OpeningMessage(OpeningDto, _lex);
        return new List<BaseMessage<OpeningDto>> { openingMsg };
    }

    public override IList<string> Aggregate()
    {
        var order = Order();
        return order.Select(message => message.Lexicalization()).ToList();
    }
}