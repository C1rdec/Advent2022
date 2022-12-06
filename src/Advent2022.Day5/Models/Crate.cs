namespace Advent2022.Day5.Models;

internal class Crate
{
    private string _value;

	public Crate(string value)
	{
		_value = value;
	}

	public string Value => _value.Substring(1, 1);
}
