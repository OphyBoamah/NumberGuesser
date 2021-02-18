using System;
using System.Security.Cryptography;

namespace NumberGuessingGame.Api
{
    // Generate random number
    //Get user's number
    //Evaluate the number
    
    class Program
    {
        static int randomNumber = new Random().Next(1, 20);
        
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Ophy's Number Guessing Game");
            Console.WriteLine("There is a secret number and you have 5 chances to guess it right");
            Console.WriteLine("Best Wishes. Let's begin!!!");
            Console.WriteLine("Hello World!");
            GetUsersGuess();
            
        }

        static int GetUsersGuess()
        {
            int guess = 0;
            
            try
            {
                Console.Write("Enter a number: ");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter a valid number");
            }
            
        
            int numberOfGuesses = 5;
            for (int i = 0; i < numberOfGuesses; i++)
            {
                
                if (guess == randomNumber)
                {
                    Console.WriteLine("That's correct. Good job!: ");
                    break;
                }
                else if (guess < randomNumber)
                {
                    Console.Write("Your number is too low. Try again: ");
                }
                else if (guess > randomNumber)
                {
                    Console.Write("Your number is too high. Try again: ");
                }

                Console.WriteLine($"The correct number was {randomNumber}");
                break;
            }
            return guess;
        }
        
    }
}