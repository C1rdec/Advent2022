namespace Advent2022.Day3.Models;

public class Compartement
{
    private string _value;

    public Compartement(string value)
    {
        _value = value;
    }

    public string Value => _value;

    public char FindMatch(Compartement compartement)
        => _value.FirstOrDefault(c => compartement.Value.Contains(c));
}
