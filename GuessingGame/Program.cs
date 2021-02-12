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

            Random random = new Random();

            int randomNumber = random.Next(1, 5);                       
            
            int ourNumber = (Convert.ToInt32(Console.ReadLine()));

            do
            {
                if (ourNumber == randomNumber)
                {
                    Console.WriteLine("You Win!");
                    break;
                }

                else if (ourNumber == 0)
                {
                    Console.Write("Your number is higher than 0:");
                    int myNewNumber = Convert.ToInt32(Console.ReadLine());
                    if (myNewNumber == randomNumber)
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (myNewNumber == -1)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You Lose!");
                    }
                    ourNumber = Convert.ToInt32(Console.ReadLine());

                    break;
                }
                else if (ourNumber == -1)
                {
                    break;
                }

                else
                {
                    if (ourNumber > randomNumber) 
                    {
                        Console.WriteLine("Your number is lower than " + ourNumber + ". Try Again");
                    }
                    else if (ourNumber < randomNumber)
                    {
                        Console.WriteLine("Your number is higher than " + ourNumber + ". Try Again");
                    }
                }

                    Console.Write("Please enter your number: ");
                    ourNumber = Convert.ToInt32(Console.ReadLine());

                    if (ourNumber == randomNumber)
                    {
                        Console.WriteLine("You win!");
                        break;
                    }

                if (ourNumber > randomNumber)
                {
                    Console.WriteLine("Your number is lower than " + ourNumber + ". Try Again");
                }
                else if (ourNumber < randomNumber)
                {
                    Console.WriteLine("Your number is higher than " + ourNumber + ". Try Again");
                }

                Console.Write("Please enter your number: ");
                    ourNumber = Convert.ToInt32(Console.ReadLine());

                    if (ourNumber == randomNumber)
                    {
                        Console.WriteLine("You win!");
                        break;
                    }

                    break;

                    

                
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
