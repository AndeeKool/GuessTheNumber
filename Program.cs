using System;

namespace GuessTheNumber
{
    class Program
    {
        //Target number to guess in the game.
        static int NumberToGuess = 0;

        static void GenerateNumberToGuess(int topLimit)
        {
            Random r = new Random();
            //Random number between 0 and the stablished top limit, must be an integer.

            NumberToGuess = r.Next(topLimit) + 1;
            Console.WriteLine("Secret Target Number is: " + NumberToGuess);
        }

        static void InputRangeSize()
        {
            bool isRangeDefined = false;

            while (!isRangeDefined)
            {
                Console.WriteLine("Hello, welcome to Guess The Number game!");
                Console.WriteLine("Please input a positive number as the maximum.");
                string userNumberInput = Console.ReadLine();

                int rangeSize = Convert.ToInt32(userNumberInput);

                //Check if input is positive and is greater than 0
                if (rangeSize > 0)
                {
                    isRangeDefined = true;
                    Console.WriteLine("Maximum number is set to: " + rangeSize);
                    Console.WriteLine();
                    GenerateNumberToGuess(rangeSize);
                }
                else
                {
                    Console.WriteLine("Invalid input! Please try again.");
                }
            }
        }

        static int UserInputGuess()
        {
            Console.Write("Enter your guess: ");
            string userInput = Console.ReadLine();
            int guess = Convert.ToInt32(userInput);
            return guess;
        }
        static void Main(string[] args)
        {

            int userGuess = 0;
            int totalGuesses = 0;

            InputRangeSize();

            while (userGuess != NumberToGuess)
            {
                userGuess = UserInputGuess();
                totalGuesses++;
                if (userGuess < NumberToGuess)
                {
                    Console.WriteLine(userGuess + " number is to low! Try again.");
                }
                else if (userGuess > NumberToGuess)
                {
                    Console.WriteLine(userGuess + " is to high! Try again.");
                }
                else
                {
                    Console.WriteLine(userGuess + " is correct! Congrats~");
                    Console.WriteLine("Total number of guesses: " + totalGuesses);
                }
            }

        }
    }
}
