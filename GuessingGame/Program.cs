using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guessing Game!");

            Console.Write("Please enter your number: ");        // Prompt

            // When the user guesses 7, the game announces they have won. All other numbers lose.

            int ourNumber = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (ourNumber != 7)
                {
                    Console.WriteLine("Try Again");
                    Console.Write("Please enter your number: ");
                    ourNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Try Again");
                    Console.Write("Please enter your number: ");
                    ourNumber = Convert.ToInt32(Console.ReadLine());
                    break;
                }

                else
                {
                    Console.WriteLine("You Win!");
                    break;
                }
            }
            while (true);


            // When the user guesses 0, the game provides instructions for the user.


            // After guessing, the user can take one more guess (unless they won!)


            // When the user guesses -1, the application should exit.


            // The game should provide feedback that the secret number is > or < any incorrect guesses.


            // The number should be random, instead of always 7.


            // Stretch task: Give the user 3 tries before announcing they have lost.


        }
    }
}
