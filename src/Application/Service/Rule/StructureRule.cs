using Questionnaire.Application.Service.Preprocessing;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Service.Rule;

public class StructureRule : IStructureRule
{
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

        // Third section
        // Check if all point are average then add no good, no bad, no advice structure
        if (IsGoodEmpty(point) && IsBadEmpty(point))
        {
            if (IsGoodFirst())
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
            if (IsGoodFirst())
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
            if (IsGoodFirst())
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
            if (IsGoodFirst())
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

        return output;
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