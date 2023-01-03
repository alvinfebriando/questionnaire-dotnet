namespace Questionnaire.Application.Lexicalization;

public interface ILexicalization
{
    public string Search(string keyword);
    public string GetStatus(double score);
}