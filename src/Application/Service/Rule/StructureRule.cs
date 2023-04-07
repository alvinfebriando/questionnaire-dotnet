using Questionnaire.Application.Service.Preprocessing;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Service.Rule;

public class StructureRule : IStructureRule
{
    private static readonly bool Igf = IsGoodFirst();
    public Structure Rule(Point point)
    {
        var output = new Structure();
        // First section
        output.Add("opening");

        // Second section
        if (Util.GetRandom(new List<int> { 0, 1 }) == 0)
        {
            output.Add("score");
            output.Add("performance");
        }
        else
        {
            output.Add("performance");
            output.Add("score");
        }
        
        // Old(output, point);
        // New1(output, point);
        New2(output, point);
        return output;
    }

    private static void Old(Structure output, Point point)
    {
        // Third section
        // Check if all point are average then add no good, no bad, no advice structure
        if (IsGoodEmpty(point) && IsBadEmpty(point))
        {
            if (Igf)
            {
                output.Add("no good");
                output.Add("no bad");
            }
            else
            {
                output.Add("no bad");
                output.Add("no good");
            }

            // Fourth section
            output.Add("no advice");
        }
        // If bad isn't empty then add advice section
        else if (IsGoodEmpty(point) && !IsBadEmpty(point))
        {
            if (Igf)
            {
                output.Add("no good");
                output.Add("bad");
            }
            else
            {
                output.Add("bad");
                output.Add("no good");
            }

            // Fourth section
            output.Add("advice");
        }
        // if Bad isn't empty but the good is then no advice
        else if (!IsGoodEmpty(point) && IsBadEmpty(point))
        {
            if (Igf)
            {
                output.Add("good");
                output.Add("no bad");
            }
            else
            {
                output.Add("no bad");
                output.Add("good");
            }

            //Fourth section
            output.Add("no advice");
        }
        // If it has good and bad
        else
        {
            if (Igf)
            {
                output.Add("good");
                output.Add("bad");
            }
            else
            {
                output.Add("bad");
                output.Add("good");
            }

            // Fourth section
            output.Add("advice");
        }
    }

    private static void New1(Structure output, Point point)
    {
        var ige = IsGoodEmpty(point);
        var ibe = IsBadEmpty(point);
        var igf = Igf;

        if (ige && ibe)
        {
            output.Add(igf ? "no good" : "no bad");
            output.Add(igf ? "no bad" : "no good");
        }
        else if (ige && !ibe)
        {
            output.Add(igf ? "no good" : "bad");
            output.Add(igf ? "bad" : "no good");
        }
        else if (!ige && ibe)
        {
            output.Add(igf ? "good" : "no bad");
            output.Add(igf ? "no bad" : "good");
        }
        else
        {
            output.Add(igf ? "good" : "bad");
            output.Add(igf ? "bad" : "good");
        }

        output.Add(ibe ? "no advice" : "advice");
    }

    private static void New2(Structure output, Point point)
    {
        var ige = IsGoodEmpty(point);
        var ibe = IsBadEmpty(point);
        var igf = Igf;

        var firstItem = igf ? (ige ? "no good" : "good") : (ibe ? "no bad" : "bad");
        var secondItem = igf ? (ibe ? "no bad" : "bad") : (ige ? "no good" : "good");
        var thirdItem = ibe ? "no advice" : "advice";

        output.Add(firstItem);
        output.Add(secondItem);
        output.Add(thirdItem);
    
    }

    private static bool IsGoodFirst()
    {
        return Util.GetRandom(new List<int> { 0, 1 }) == 0;
    }

    private static bool IsGoodEmpty(Point point)
    {
        return point.Good.Count == 0;
    }

    private static bool IsBadEmpty(Point point)
    {
        return point.Bad.Count == 0;
    }
}