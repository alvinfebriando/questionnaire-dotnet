namespace Questionnaire.Domain.Entities;

public class Structure
{
    private readonly IList<string> _structures = new List<string>();

    public void Add(string s)
    {
        _structures.Add(s);
    }

    public string Get(int index)
    {
        return _structures[index];
    }
}