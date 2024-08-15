using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Menu
    {

        GameEngine engine = new GameEngine();
        internal void ShowMenu(string? name, DateTime date)
        {

            Console.Clear();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Hello {name}, it's {date}. This is your math game. That's great that you're working on improving yourself.\n");
            Console.WriteLine(@$"What game would you like to play today? Choose from the options below:

A - Addition
S - Subtraction
M - Multiplication
D - Division
V - View Game History
Q - Quit the program
"
);

            Console.WriteLine("Windows " + 7 + 4);
            Console.WriteLine("-------------------------------------------\n");

            var choice = Console.ReadLine();

            switch (choice.Trim().ToLower())
            {
                case "a":
                    engine.AdditionGame();
                    break;
                case "s":
                    engine.SubtractionGame();
                    break;
                case "m":
                    engine.MultiplicationGame();
                    break;
                case "d":
                    engine.DivisionGame();
                    break;
                case "v":
                    Helpers.ViewGameHistory();
                    break;
                case "q":
                    Console.WriteLine("Goodbye.");
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Unknown input.");
                    Environment.Exit(1);
                    break;
            };
        }
    }
}
