using System;

namespace GuessTheNumber
{
    class Program
    {
        static int RangeSize = 0;

        static void InputRangeSize()
        {
            bool isRangeDefined = false;

            while (!isRangeDefined) 
            {
                Console.WriteLine("Hello, welcome to Guess The Number game!");
                Console.WriteLine("Please input a positive number as the maximum.");
                string userNumberInput = Console.ReadLine();

                RangeSize = Convert.ToInt32(userNumberInput);

                //Check if input is positive and is greater than 0
                if (RangeSize > 0)
                {
                    isRangeDefined = true;
                    Console.WriteLine("Maximum number is set to: " + RangeSize);
                    Console.WriteLine();
                    //GenerateNumberToGuess();
                }
                else
                {
                    Console.WriteLine("Invalid input! Please try again");
                }
            }
        }
        static void Main(string[] args)
        {
            InputRangeSize();
        }
    }
}
