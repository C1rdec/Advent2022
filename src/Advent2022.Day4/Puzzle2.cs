using Advent2022.Core;
namespace Advent2022.Day4;

using Advent2022.Day4.Models;

public class Puzzle2 : PuzzleBase
{
    protected override string Solve(string input)
    {
        var lines = input.Split(Environment.NewLine);
        var groups = lines.Select(l => new AssigmentGroup(l));

        var count = 0;
        foreach (var group in groups)
        {
            if (group.AnyOverlap())
            {
                count++;
            }
        }

        return count.ToString();
    }
}
