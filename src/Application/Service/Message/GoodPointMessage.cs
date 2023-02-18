﻿using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Message;

public class GoodPointMessage : BaseMessage<PointDto>, IMultiLexicalizationMessage, IComplemented
{
    private readonly ILexicalization _lex;

    public GoodPointMessage(PointDto data, ILexicalization lex) : base(data)
    {
        _lex = lex;
        Complement.Add("");
    }

    public IList<string> Complement { get; set; } = new List<string>();

    public void EmbedComplement(Option option)
    {
        Complement[0] = option.Description switch
        {
            "bad" => _lex.Search("meskipun demikian") + ", ",
            "no bad" => _lex.Search("serta") + ", ",
            _ => Complement[0]
        };
    }
    private string _template1 =
        "{Complement[0]}untuk {_lex.Search(aspek)} {Data.Answer.Section}, {Data.Lecturer} sudah menjalankannya dengan baik, dengan {_lex.Search(nilai)} yang {_lex.Search(didapatkan)} adalah {Data.Answer.AverageScore}.";


    private string _template2 =
        "{Complement[0]}untuk {_lex.Search(aspek)} {Data.Answer.Section} dan {second.Section}, {Data.Lecturer} sudah menjalankannya dengan baik, dengan {_lex.Search(nilai)} yang {_lex.Search(didapatkan)} masing-masing adalah {Data.Answer.AverageScore} dan {second.AverageScore}.";

    private string _template3 =
        "{Complement[0]}untuk {_lex.Search(aspek)} {Data.Answer.Section}, {second.Section}, dan {third.Section}, {Data.Lecturer} sudah menjalankannya dengan baik, dengan {_lex.Search(nilai)} yang {_lex.Search(didapatkan)} masing-masing adalah {Data.Answer.AverageScore}, {second.AverageScore}, {third.AverageScore}.";

    public string Lexicalization(IList<AveragedAnswer> messages)
    {
        var sentence = "";
        var second = messages[1];
        switch (messages.Count)
        {
            case 2:
                sentence = _template2;
                sentence = sentence.Replace("{Complement[0]}", Complement[0])
                    .Replace("{_lex.Search(aspek)}", _lex.Search("aspek"))
                    .Replace("{Data.Answer.Section}", Data.Answer.Section.ToString())
                    .Replace("{second.Section}", second.Section.ToString())
                    .Replace("{Data.Lecturer}", Data.Lecturer)
                    .Replace("_lex.Search(nilai)", _lex.Search("nilai"))
                    .Replace("_lex.Search(didapatkan)", _lex.Search("didapatkan"))
                    .Replace("{Data.Answer.AverageScore}", Data.Answer.AverageScore.ToString())
                    .Replace("{second.AverageScore}", second.AverageScore.ToString());
                break;
            case >= 3:
                var third = messages[2];
                sentence = _template3;
                sentence = sentence.Replace("{Complement[0]}", Complement[0])
                    .Replace("{_lex.Search(aspek)}", _lex.Search("aspek"))
                    .Replace("{Data.Answer.Section}", Data.Answer.Section.ToString())
                    .Replace("{second.Section}", second.Section.ToString())
                    .Replace("{third.Section}", third.Section.ToString())
                    .Replace("{Data.Lecturer}", Data.Lecturer)
                    .Replace("_lex.Search(nilai)", _lex.Search("nilai"))
                    .Replace("_lex.Search(didapatkan)", _lex.Search("didapatkan"))
                    .Replace("{Data.Answer.AverageScore}", Data.Answer.AverageScore.ToString())
                    .Replace("{second.AverageScore}", second.AverageScore.ToString())
                    .Replace("{third.AverageScore}", third.AverageScore.ToString());
                break;
        }

        return sentence;
    }

    public override string Lexicalization()
    {
        var sentence = _template1.Replace("{Complement[0]}", Complement[0])
            .Replace("{_lex.Search(aspek)}", _lex.Search("aspek"))
            .Replace("{Data.Answer.Section}", Data.Answer.Section.ToString())
            .Replace("{Data.Lecturer}", Data.Lecturer)
            .Replace("_lex.Search(nilai)", _lex.Search("nilai"))
            .Replace("_lex.Search(didapatkan)", _lex.Search("didapatkan"))
            .Replace("{Data.Answer.AverageScore}", Data.Answer.AverageScore.ToString());
        return sentence;
    }
}