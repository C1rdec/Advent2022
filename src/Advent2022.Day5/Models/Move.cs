namespace Advent2022.Day5.Models;

internal class Move
{
    public Move(string value)
    {
        var t = value.Split(" ");
        Count = int.Parse(t[1]);
        From = int.Parse(t[3]);
        To = int.Parse(t[5]);
    }

    public int Count { get; init; }

    public int From { get; init; }

    public int To { get; init; }
}
