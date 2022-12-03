using System;
using Advent2022.Core;

namespace Advent2022.Day2
{
    public class Puzzle2 : PuzzleBase
    {
        protected override string Solve(string input)
        {
            var matches = input.Split(System.Environment.NewLine);
            var points = 0;

            foreach (var match in matches)
            {
                var players = match.Split(" ");

                var player1 = (Player1Choice)players[0][0];
                var matchResult = (MatchResult)players[1][0];

                var player2 = GetPlayer2Choice(player1, matchResult);

                var victoryPoints = matchResult switch
                {
                    MatchResult.Win => 6,
                    MatchResult.Lose => 0,
                    MatchResult.Draw => 3,
                    _ => throw new NotImplementedException(),
                };

                points += victoryPoints;

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

        private Player2Choice GetPlayer2Choice(Player1Choice player1, MatchResult matchResult)
        {
            var player1Value = player1.ToString();
            if (matchResult == MatchResult.Draw)
            {
                return Enum.Parse<Player2Choice>(player1Value);
            }


            switch (matchResult)
            {
                case MatchResult.Win:
                    switch (player1)
                    {
                        case Player1Choice.Rock:
                            return Player2Choice.Paper;
                        case Player1Choice.Paper:
                            return Player2Choice.Scisor;
                        case Player1Choice.Scisor:
                            return Player2Choice.Rock;
                    }

                    break;
                case MatchResult.Lose:
                    switch (player1)
                    {
                        case Player1Choice.Rock:
                            return Player2Choice.Scisor;
                        case Player1Choice.Paper:
                            return Player2Choice.Rock;
                        case Player1Choice.Scisor:
                            return Player2Choice.Paper;
                    }

                    break;
            }

            throw new InvalidOperationException("Not a valid Match result");
        }
            
    }
}
