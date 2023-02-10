namespace Questionnaire.Application.Common.Interfaces;

public interface ILexicalization
{
    public string Search(string keyword);
    public string GetStatus(double score);
}