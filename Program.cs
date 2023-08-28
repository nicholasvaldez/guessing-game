using System;

Console.WriteLine("Hello! Welcome to The Guessing Game!");
Console.WriteLine("-----------------------");
Console.Write("Please guess the secret number: ");

string input = Console.ReadLine();
int parsedInput = int.Parse(input);

int secretNumber = 42;

if (parsedInput == secretNumber)
{
    Console.WriteLine("Buy a lottery ticket right now, that's correct!");
}
else 
{
    Console.WriteLine("Sorry, guess again!");
}