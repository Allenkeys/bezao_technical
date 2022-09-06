using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;




namespace bezao_technical
{
    public class GuessingGame
    {
        public static void guess()
        {

            // Intialize secretnumber, number of game rounds and variable to hold user current guess
            int secretNumber = 5;
            int numOfTries = 3;
            int currentGuess = 0;

            while(numOfTries > 0)
            {
                int userInput;
                // Check only integer is keyed in by user
                try
                {
                    Console.Write("Guess the secret number: ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("That wasn't a number");
                    return;
                }
                // If guess is correct, terminate program
                if(secretNumber == userInput)
                {
                    Console.WriteLine("Your guess is correct...");
                    break;
                }
                // 
                if (secretNumber != userInput)
                {
                    // Check if user input matches previous guess
                    // Yes! don't reduce game time
                    if(currentGuess == userInput)
                    {
                        numOfTries += 1;
                        Console.WriteLine("You repeated previous input");
                    }
                    if(userInput > secretNumber){
                        Console.WriteLine("Your input is too large");
                    }
                    else
                    {
                        Console.WriteLine("Your input is too small");
                    }

                    // Set currentGuess to user input to check consecutive repeated guesses.
                    // Reduce game round if need be
                    numOfTries--;
                    currentGuess = userInput;
                    Console.WriteLine($"You have {numOfTries} tries left");
                }
            }
        }
    }
}