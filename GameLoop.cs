using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    public class GameLoop
    {
        public GameLoop() 
        {
            int numberToGuess = new Random().Next(1, 101);

            bool validInput = false;
            int guess;
            do
            {
                Console.WriteLine(Prompt.InitialPrompt());
                string? guessString = Console.ReadLine();
                validInput = int.TryParse(guessString, out guess);
                if (!validInput)
                {
                    Console.WriteLine(Prompt.Error());
                }
            } while (!validInput);    

            while (guess != numberToGuess)
            {
                    Console.WriteLine(Prompt.Loss(guess, numberToGuess));
                    guess = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(Prompt.Win(numberToGuess));

            Console.WriteLine(Prompt.PlayAgain());
            string? response = Console.ReadLine();
            switch (response?.ToLower())
            {
                case "y":
                    GameLoop newGame = new GameLoop();
                    break;
                case "yes":
                    newGame = new GameLoop();
                    break;
                case "yeah":
                    newGame = new GameLoop();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }

        }
    }
}
