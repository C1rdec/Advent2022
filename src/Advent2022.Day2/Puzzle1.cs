namespace Advent2022.Day2;

using Advent2022.Core;
using Advent2022.Day2.Models;

public class Puzzle1 : PuzzleBase
{
    protected override string Solve(string input)
    {
        var matches = input.Split(System.Environment.NewLine);
        var points = 0;

        foreach (var match in matches)
        {
            var players = match.Split(" ");

            var player1 = (Player1Choice)players[0][0];
            var player2 = (Player2Choice)players[1][0];

            var result = ProcessMatch(player1, player2);
            if (result == null)
            {
                points += 3;
            }
            else if (result.Value)
            {
                points += 6;
            }

            switch (player2)
            {
                case Player2Choice.Rock:
                    points += 1;
                    break;
                case Player2Choice.Paper:
                    points += 2;
                    break;
                case Player2Choice.Scisor:
                    points += 3;
                    break;
            }
        }

        return points.ToString();
    }

    private bool? ProcessMatch(Player1Choice player1, Player2Choice player2)
    {
        if (player1.ToString() == player2.ToString())
        {
            // Tie
            return null;
        }

        switch (player2)
        {
            case Player2Choice.Rock:
                return player1 == Player1Choice.Scisor;
            case Player2Choice.Paper:
                return player1 == Player1Choice.Rock;
            case Player2Choice.Scisor:
                return player1 == Player1Choice.Paper;
        }

        return false;
    }
}
