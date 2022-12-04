namespace Advent2022.Day3.Models;

internal class Rubsack
{
    public static readonly int LowerIndex = 96;
    public static readonly int UpperIndex = 38;
    private string _value;
    private Compartement _firstCompartement;
    private Compartement _secondCompartement;
    private int _length;

    public Rubsack(string value)
    {
        _value = value;
        _length = value.Length / 2;

        _firstCompartement = new Compartement(value.Substring(0, _length));
        _secondCompartement = new Compartement(value.Substring(_length));
    }

    public static int GetPriorities(char value)
    {
        var startIndezx = char.IsUpper(value) ? UpperIndex : LowerIndex;

        return value - startIndezx;
    }

    public string Value => _value;

    public int GetItemPriorities()
        => GetPriorities(_firstCompartement.FindMatch(_secondCompartement));

    public IEnumerable<char> FindMatches(Rubsack sack)
        => _value.Where(c => sack.Value.Contains(c));
}
