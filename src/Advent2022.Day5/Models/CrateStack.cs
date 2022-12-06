namespace Advent2022.Day5.Models;

using System.Collections.Generic;

internal class CrateStack
{
    private Stack<Crate> _crates;

    public CrateStack()
    {
        _crates = new Stack<Crate>();
    }

    public void Add(IEnumerable<Crate> crates)
    {
        foreach (var crate in crates)
        {
            _crates.Push(crate);
        }
    }

    public void Add(Crate crate)
        => _crates.Push(crate);

    public IEnumerable<Crate> Remove(int count)
    {
        var crates = new List<Crate>();
        for (int i = 0; i < count; i++)
        {
            crates.Add(_crates.Pop());
        }

        crates.Reverse();

        return crates;
    }

    public Crate Remove()
        => _crates.Pop();
}
