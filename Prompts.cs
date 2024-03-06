using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    public static class Prompts
    {
        public static string InitialPrompt()
        {
            return "Guess a number between 1 and 100:   ";
        }
        public static string Win(int guess, int cpuNumber)
        {
            return "You guessed it! Congrats!" ;
        }
        public static string Loss(int guess, int cpuNumber)
        {
            if (guess < cpuNumber)
            {
                return "Guess is too low, try again.";
            }
            else
            {
                return "Guess is too high, try again.";
            }
        }
        public static string PlayAgain()
        {
            return "Play again? Y, or Yes to start again.";
        }
        public static string Error()
        {
            return "Not a valid input.";
        }
    }
}
