using System;
using System.ComponentModel;

Console.WriteLine("Hello! Welcome to The Guessing Game!");
Console.WriteLine("-----------------------");
for (int i = 0; i < 4; i++)
{
    Console.Write("Please guess the secret number: ");
    

    string input = Console.ReadLine();
    int parsedInput = int.Parse(input);

    int secretNumber = 42;
    Console.WriteLine($"Guess {i + 1} of 4");


    if (parsedInput != secretNumber)
    {
        Console.WriteLine("Sorry, thats incorrect!");
        
    }
    else 
    {
        Console.WriteLine("Buy a lottery ticket right now, that's correct!");
        break;
    }

}