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
            Console.WriteLine("There is a secret number and you have just two chances to guess it right");
            Console.WriteLine("Best Wishes. Let's begin!!!");
            //GetUsersGuess();
            ValidateGuess();
            

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
            return guess;

        }

        static int ValidateGuess()
        {
            int tries = 0;
            
            for (var i = 0; i < 5; i++)
            {
                int guess = GetUsersGuess();
                
                if (guess < randomNumber)
                {
                    Console.WriteLine("Your number is too low. ");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Your number is too high.");
                } else if (guess == randomNumber)
                {
                    Console.WriteLine("That's correct. Good job!: ");
                    break; 
                }

            } Console.WriteLine($"The correct number was {randomNumber}");

            return tries;
        }
        
    }
}