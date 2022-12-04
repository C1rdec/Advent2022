namespace Advent2022.Day3;

using Advent2022.Core;
using Advent2022.Day3.Models;

public class Puzzle1 : PuzzleBase
{
    protected override string Solve(string input)
    {
        var sum = 0;
        var lines = input.Split(System.Environment.NewLine);

        foreach (var line in lines)
        {
            sum += new Rubsack(line).GetItemPriorities();
        }

        return sum.ToString();
    }
}