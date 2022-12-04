namespace Advent2022.Day1;

using Advent2022.Core;

public class Puzzle1 : PuzzleBase
{
    protected override string Solve(string input)
    {
        var lines = input.Split(System.Environment.NewLine);
        var maxCalories = 0;
        var currentCalories = 0;

        foreach (var line in lines)
        {
            if (string.IsNullOrEmpty(line))
            {
                if (currentCalories > maxCalories)
                {
                    maxCalories = currentCalories;
                }

                currentCalories = 0;
                continue;
            }

            currentCalories += int.Parse(line);
        }

        return maxCalories.ToString();
    }
}