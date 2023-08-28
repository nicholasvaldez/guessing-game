using System;
using System.Collections.Generic;
using System.ComponentModel;

Console.WriteLine("Hello! Welcome to The Guessing Game!");
Console.WriteLine("-----------------------");

Random r = new Random();
int secretNumber = r.Next(0,100);
    // Console.WriteLine(secretNumber);

List<int> difficultyLevels = new List<int>()
{
8, 6, 4
};

Console.WriteLine("Easy, Medium, or Hard? ");
Console.Write("> ");

string difficultyInput = Console.ReadLine().ToLower();

int difficultyLevel = 0;

if (difficultyInput == "easy")
{
     difficultyLevel = difficultyLevels[0];
}
else if (difficultyInput == "medium")
{
     difficultyLevel = difficultyLevels[1];

}
else if (difficultyInput == "hard")
{
     difficultyLevel = difficultyLevels[2];

}



for (int i = 0; i < difficultyLevel; i++)
{
    int remainingGuesses = difficultyLevel - i - 1;
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