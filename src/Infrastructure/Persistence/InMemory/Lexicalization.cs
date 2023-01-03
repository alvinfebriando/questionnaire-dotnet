using Questionnaire.Application;
using Questionnaire.Application.Lexicalization;

namespace Questionnaire.Infrastructure.Persistence.InMemory;

public class Lexicalization : ILexicalization
{
    public string RndResponden()
    {
        return "responden";
    }

    public string RndMendapat()
    {
        return "responden";
    }

    public string RndTertinggi()
    {
        return "responden";
    }

    public string RndTerendah()
    {
        return "responden";
    }

    public string RndNilai()
    {
        return "responden";
    }

    public string GetStatus(double score)
    {
        return "responden";
    }
}