namespace Questionnaire.Application;

public static class Util
{
    public static T GetRandom<T>(IList<T> list)
    {
        Random rnd = new();
        var index = rnd.Next(0, list.Count);
        return list[index];
    }
}