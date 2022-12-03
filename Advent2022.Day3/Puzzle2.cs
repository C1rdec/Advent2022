using Advent2022.Core;
using Advent2022.Day3.Models;

namespace Advent2022.Day3
{
    public class Puzzle2 : PuzzleBase
    {
        protected override string Solve(string input)
        {
            var lines = input.Split(Environment.NewLine);

            var sum = 0;
            var skip = 0;
            do
            {
                var sacks = lines.Skip(skip).Take(3).Select(l => new Rubsack(l));
                var group = new Group(sacks);

                sum += group.FindBadge();

                skip += 3;
            }
            while (lines.Length > skip);

            return sum.ToString();
        }
    }
}
