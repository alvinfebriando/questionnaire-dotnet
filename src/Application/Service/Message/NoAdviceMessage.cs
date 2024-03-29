﻿using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Application.Service.Preprocessing;

namespace Questionnaire.Application.Service.Message;

public class NoAdviceMessage : BaseMessage<CLosingDto>
{
    private readonly ILexicalization _lex;

    public NoAdviceMessage(
        CLosingDto data,
        ILexicalization lex,
        ITemplateProvider templateProvider) : base(data)
    {
        _lex = lex;
        Template = templateProvider.Get("no advice");
    }

    private Dictionary<string, string> LoadReplacement()
    {
        return new Dictionary<string, string> { { "{Lecturer}", Data.Lecturer } };
    }

    public override string EntitySlotting()
    {
        var advice = Util.GetRandom(Data.Advice);
        var replacement = LoadReplacement();
        replacement.Add("{advice}", advice);
        var sentence = Replace(replacement);
        return sentence;
    }
}