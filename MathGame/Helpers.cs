using MathGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Helpers
    {

        internal static List<Game> games = new List<Game>
        {
            //new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
            //new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
            //new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
            //new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
            //new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
            //new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
            //new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
            //new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
            //new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },
        };

        internal static void AddToGameHistory(int score, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = score,
                Type = gameType
            });

            //games.Add($"{DateTime.Now} - {gameType}: Score = {score}");
        }

        internal static void ViewGameHistory()
        {

            //var gamesToPrint = games.Where(x => x.Type == GameType.Division).OrderByDescending(x => x.Score);

            Console.WriteLine("\n Game History");
            Console.WriteLine("------------------------------");
            foreach (Game game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} pts");
            }
            Console.WriteLine("------------------------------\n");
            Console.ReadLine();
        }

        internal static void GameOverPrompt(int score)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Game over. Your final score is {score}.\n");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            int firstNumber, secondNumber;

            do
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            } while (firstNumber % secondNumber != 0);

            return new int[] { firstNumber, secondNumber };
        }

        internal static string? ValidateResult(string result)
        {
            while (string.IsNullOrWhiteSpace(result) || !int.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be an integer. Try again.");
                result = Console.ReadLine();
            }
            return result;
        }

        internal static string GetName()
        {
            Console.WriteLine("Please write your name.");
            var name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name can't be empty.");
                name = Console.ReadLine();
            }

            return name;
        }

    }
}
