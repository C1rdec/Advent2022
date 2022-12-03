using System.Collections.Generic;
using System.Linq;
using Advent2022.Core;

namespace Advent2022.Day1
{
    public class Puzzle2 : PuzzleBase
    {
        protected override string Solve(string input)
        {
            var values = new List<int>();
            var lines = input.Split(System.Environment.NewLine);

            var currentCalories = 0;
            foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    values.Add(currentCalories);
                    currentCalories = 0;

                    continue;
                }

                currentCalories += int.Parse(line);
            }

            var orderedValues = values.OrderByDescending(e => e);

            return orderedValues.Take(3).Sum().ToString();
        }
    }
}