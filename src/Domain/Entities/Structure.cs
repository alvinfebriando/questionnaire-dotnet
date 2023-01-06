namespace Questionnaire.Domain.Entities;

public class Structure
{
    private readonly IList<string> _structures = new List<string>();

    public void Add(string s)
    {
        _structures.Add(s);
    }

    public void AddRange(IEnumerable<string> s)
    {
        ((List<string>)_structures).AddRange(s);
    }

    public string Get(int index)
    {
        return _structures[index];
    }

    public int Get(string s)
    {
        return _structures.IndexOf(s);
    }

    public override string? ToString()
    {
        return string.Join(", ", _structures);
    }
}