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
            int cpuNumber = new Random().Next(1, 101);

            bool validInput = false;
            int guess;
            do
            {
                Console.WriteLine(Prompts.InitialPrompt());
                string? guessString = Console.ReadLine();
                validInput = int.TryParse(guessString, out guess);
                if (!validInput)
                {
                    Console.WriteLine(Prompts.Error());
                }
            } while (!validInput);    

            while (guess != cpuNumber)
            {
                    Console.WriteLine(Prompts.Loss(guess, cpuNumber));
                    guess = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(Prompts.Win(guess, cpuNumber));

            Console.WriteLine(Prompts.PlayAgain());
            string? response = Console.ReadLine();
            switch (response?.ToLower())
            {
                case "y":
                    GameLoop newGame = new GameLoop();
                    break;
                case "yes":
                    newGame = new GameLoop();
                    break;
                case "yea":
                    newGame = new GameLoop();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }

        }
    }
}
