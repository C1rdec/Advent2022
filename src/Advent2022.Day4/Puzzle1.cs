namespace Advent2022.Day4;

using Advent2022.Core;
using Advent2022.Day4.Models;

public class Puzzle1 : PuzzleBase
{
    protected override string Solve(string input)
    {
        var lines = input.Split(Environment.NewLine);
        var groups = lines.Select(l => new AssigmentGroup(l));

        var count = 0;
        foreach(var group in groups)
        {
            if (group.IsFullyContained())
            {
                count++;
            }
        }

        return count.ToString();
    }
}