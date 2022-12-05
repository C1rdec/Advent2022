namespace Advent2022.Day2;

using System;
using System.Numerics;
using Advent2022.Core;
using Advent2022.Day2.Models;

public class Puzzle2 : PuzzleBase
{
    protected override string Solve(string input)
    {
        var matches = input.Split(Environment.NewLine);
        var points = 0;

        foreach (var match in matches)
        {
            var players = match.Split(" ");

            var player1 = (Player1Choice)players[0][0];
            var matchResult = (MatchResult)players[1][0];

            var player2 = GetPlayer2Choice(player1, matchResult);

            points += matchResult switch
            {
                MatchResult.Win => 6,
                MatchResult.Lose => 0,
                MatchResult.Draw => 3,
                _ => throw new NotImplementedException(),
            };

            points += player2 switch
            {
                Player2Choice.Rock => 1,
                Player2Choice.Paper => 2,
                Player2Choice.Scisor => 3,
                _ => throw new NotImplementedException(),
            };
        }

        return points.ToString();
    }

    private Player2Choice GetPlayer2Choice(Player1Choice player1, MatchResult matchResult)
    {
        var player1Value = player1.ToString();
        if (matchResult == MatchResult.Draw)
        {
            return Enum.Parse<Player2Choice>(player1Value);
        }

        return matchResult switch
        {
            MatchResult.Win => player1 switch
            {
                Player1Choice.Rock => Player2Choice.Paper,
                Player1Choice.Paper => Player2Choice.Scisor,
                Player1Choice.Scisor => Player2Choice.Rock,
                _ => throw new NotImplementedException(),
            },
            MatchResult.Lose => player1 switch
            {
                Player1Choice.Rock => Player2Choice.Scisor,
                Player1Choice.Paper => Player2Choice.Rock,
                Player1Choice.Scisor => Player2Choice.Paper,
                _ => throw new NotImplementedException(),
            },
            _ => throw new NotImplementedException(),
        };
    }
}
