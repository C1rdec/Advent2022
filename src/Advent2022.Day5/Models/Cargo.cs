namespace Advent2022.Day5.Models;

using System;
using System.Collections.Generic;
using System.Linq;

internal class Cargo
{
    private List<CrateStack> _stacks;

	public Cargo(string value)
	{
		_stacks = new List<CrateStack>()
		{
			new CrateStack(),
			new CrateStack(),
			new CrateStack(),
			new CrateStack(),
			new CrateStack(),
			new CrateStack(),
			new CrateStack(),
			new CrateStack(),
			new CrateStack(),
        };

		var lines = value.Split(Environment.NewLine).Reverse();

		// Skip crate number
		foreach (var line in lines.Skip(1))
		{
			var lineValue = line;
			for (int i = 0; i < 9; i++)
			{
                var crateValue = lineValue.Substring(0, 3);

				if (lineValue.Length > 4)
				{
					lineValue = lineValue.Substring(4);
				}

				if (string.IsNullOrEmpty(crateValue.Trim()))
				{
					continue;
				}

				_stacks[i].Add(new Crate(crateValue));
            }
		}
	}

	public void MoveCrates(Move move)
	{
		var fromStack = _stacks[move.From - 1];
		var toStack = _stacks[move.To - 1];

		for (var i = 0; i < move.Count; i++)
		{
			toStack.Add(fromStack.Remove());
		}
	}

	public void MoveMultipleCrates(Move move)
	{
        var fromStack = _stacks[move.From - 1];
        var toStack = _stacks[move.To - 1];

		var crates = fromStack.Remove(move.Count);

        toStack.Add(crates);
    }

	public string Print()
	{
		var result = "";
		foreach(var stack in _stacks)
		{
			var firstCrate = stack.Remove();
			result += firstCrate.Value;
		}

		return result;
	}
}
