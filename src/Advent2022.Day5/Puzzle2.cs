namespace Advent2022.Day5;

using Advent2022.Core;
using Advent2022.Day5.Models;

public class Puzzle2 : PuzzleBase
{
    protected override string Solve(string input)
    {
        var values = input.Split(System.Environment.NewLine + System.Environment.NewLine);
        var cargo = new Cargo(values[0]);

        var moveValues = values[1].Split(System.Environment.NewLine);
        foreach (var moveValue in moveValues)
        {
            cargo.MoveMultipleCrates(new Move(moveValue));
        }

        return cargo.Print();
    }
}
