using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathGame.Models;

namespace MathGame
{
    internal class GameEngine
    {
        internal void AdditionGame()
        {
            Console.Clear();

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"\n{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your answer was correct! \n");
                    score++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your answer was incorrect. \n");
                }
            }

            Helpers.GameOverPrompt(score);
            Helpers.AddToGameHistory(score, GameType.Addition);
        }

        internal void SubtractionGame()
        {

            Console.Clear();
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"\n{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your answer was correct! \n");
                    score++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your answer was incorrect. \n");
                }
            }

            Helpers.GameOverPrompt(score);
            Helpers.AddToGameHistory(score, GameType.Subtraction);
        }

        internal void MultiplicationGame()
        {

            Console.Clear();
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"\n{firstNumber} X {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your answer was correct! \n");
                    score++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your answer was incorrect. \n");
                }
            }

            Helpers.GameOverPrompt(score);
            Helpers.AddToGameHistory(score, GameType.Multiplication);
        }

        internal void DivisionGame()
        {
            Console.Clear();
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;

                var divisionNumbers = Helpers.GetDivisionNumbers();

                firstNumber = divisionNumbers[0];
                secondNumber = divisionNumbers[1];

                Console.WriteLine($"\n{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your answer was correct! \n");
                    score++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your answer was incorrect. \n");
                }
            }

            Helpers.GameOverPrompt(score);
            Helpers.AddToGameHistory(score, GameType.Division);
        }
    }
}
