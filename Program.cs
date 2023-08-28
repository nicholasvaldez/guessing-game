using System;
using System.ComponentModel;

Console.WriteLine("Hello! Welcome to The Guessing Game!");
Console.WriteLine("-----------------------");

Random r = new Random();
    int secretNumber = r.Next(0,100);
    // Console.WriteLine(secretNumber);

for (int i = 0; i < 4; i++)
{
    int remainingGuesses = 3 - i;
    Console.Write("Please guess the secret number: ");
    

    string input = Console.ReadLine();
    int parsedInput = int.Parse(input);


    
    
    Console.WriteLine($"Guess #{i + 1}. {remainingGuesses} guesses remaining.");


    if (parsedInput != secretNumber)
    {
        Console.WriteLine("Sorry, thats incorrect!");
        if (parsedInput < secretNumber)
        {
            Console.WriteLine("Too low!!");
        }
        else 
        {
            Console.WriteLine("Too High!!");
        }
        
    }
    else 
    {
        Console.WriteLine("Buy a lottery ticket right now, that's correct!");
        break;
    }

}