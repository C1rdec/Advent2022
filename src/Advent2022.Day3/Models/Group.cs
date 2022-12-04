namespace Advent2022.Day3.Models;

internal class Group
{
    private Rubsack _firstSack;
    private Rubsack _secondSack;
    private Rubsack _thirdSack;

    public Group(IEnumerable<Rubsack> sacks)
    {
        _firstSack = sacks.ElementAt(0);
        _secondSack = sacks.ElementAt(1);
        _thirdSack = sacks.ElementAt(2);
    }

    public int FindBadge()
    {
        var matches = _firstSack.FindMatches(_secondSack);

        var match = _thirdSack.Value.FirstOrDefault(c => matches.Contains(c));
        if (match == default)
        {
            throw new InvalidOperationException("Match not found");
        }

        return Rubsack.GetPriorities(match);
    }
}
