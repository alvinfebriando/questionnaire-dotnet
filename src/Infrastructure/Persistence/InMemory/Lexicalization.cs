using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Preprocessing;

namespace Questionnaire.Infrastructure.Persistence.InMemory;

public class Lexicalization : ILexicalization
{
    private readonly Dictionary<string, string> _synonym = new();

    public Lexicalization()
    {
        _synonym.Add("mendapat", "mendapat");
        _synonym.Add("menerima", "mendapat");
        _synonym.Add("didapatkan", "didapatkan");
        _synonym.Add("diterima", "didapatkan");
        _synonym.Add("nilai", "nilai");
        _synonym.Add("skor", "nilai");
        _synonym.Add("tertinggi", "tertinggi");
        _synonym.Add("paling tinggi", "tertinggi");
        _synonym.Add("terendah", "terendah");
        _synonym.Add("paling rendah", "terendah");
        _synonym.Add("meskipun demikian", "meskipun demikian");
        _synonym.Add("walaupun demikian", "meskipun demikian");
        _synonym.Add("namun", "namun");
        _synonym.Add("tetapi", "namun");
        _synonym.Add("serta", "serta");
        // _synonym.Add("dan juga", "serta");
        _synonym.Add("kemudian", "serta");
        _synonym.Add("lalu", "serta");
        _synonym.Add("untuk", "untuk");
        _synonym.Add("pada", "untuk");
        _synonym.Add("sedangkan", "sedangkan");
        _synonym.Add("aspek", "aspek");
        _synonym.Add("bagian", "aspek");
    }

    public string Search(string keyword)
    {
        var output = _synonym.Where(s => s.Value == keyword).Select(s => s.Key).ToList();
        return Util.GetRandom(output);
    }

    public string GetStatus(double score)
    {
        const double tolerance = 1e-10;
        if (Math.Abs(Math.Round(score) - 1) < tolerance) return "sangat tidak baik";

        if (Math.Abs(Math.Round(score) - 2) < tolerance) return "tidak baik";

        if (Math.Abs(Math.Round(score) - 3) < tolerance) return "cukup";

        return Math.Abs(Math.Round(score) - 4) < tolerance ? "baik" : "sangat baik";
    }
}