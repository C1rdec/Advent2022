namespace Advent2022.Core;

using System.IO;

public abstract class PuzzleBase
{
    public string Solve()
        => Solve(GetInput());

    protected abstract string Solve(string input);

    private string GetInput()
    {
        var puzzleType = GetType();
        var resourcePath = $"{puzzleType.Namespace}.Input.txt";
        using var stream =  puzzleType.Assembly.GetManifestResourceStream(resourcePath);
        using var reader = new StreamReader(stream);

        return reader.ReadToEnd();
    }
}