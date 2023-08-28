# The Guessing Game App 

## Table of Contents

1. [Introduction](#introduction)
2. [Getting Started](#getting-started)
    - [Requirements](#requirements)
    - [Installation](#installation)
3. [Usage](#usage)
    - [Gameplay](#gameplay)
    - [Difficulty Levels](#difficulty-levels)
4. [Code Overview](#code-overview)
    - [Main Function](#main-function)
    - [Difficulty Levels List](#difficulty-levels-list)
    - [Guessing Loop](#guessing-loop)

## Introduction<a name="introduction"></a>

Welcome to **The Guessing Game** documentation! This app is a simple console-based game where players attempt to guess a randomly generated secret number within a specified number of attempts. The game offers different difficulty levels to challenge players with varying levels of guessing skill.

## Getting Started<a name="getting-started"></a>

### Requirements<a name="requirements"></a>

To run the Guessing Game App, you'll need:

- A computer with a compatible operating system (Windows, macOS, or Linux).
- .NET runtime installed.

### Installation<a name="installation"></a>

1. **Fork the Repository**: To get started, you'll need the source code for the app. If you don't have it already, you can fork the [Guessing Game GitHub repository](https://github.com/nicholasvaldez/guessing-game) to your GitHub account. This will create a copy of the repository under your account.

2. **Clone the Repository**: Once you've forked the repository, navigate to your fork on GitHub and copy the repository's URL.

3. **Open a Terminal or Command Prompt**: On your computer, open a terminal.

4. **Navigate to a Directory**: Choose or create a directory on your computer where you want to store the project files. Use the `cd` command to navigate to that directory in the terminal.

5. **Clone the Repository**: In the terminal, use the following command to clone the repository to your local machine. Replace `<repository-url>` with the URL you copied earlier.

   ```bash
   git clone <repository-url>
   ```
6. **Run the Application**: Ensure you are in the app directory `cd guessing-game` and run the app using `dotnet run`

### Usage<a name="usage"></a>
#### Gameplay<a name="gameplay"></a>

1. When you start the game, you'll be greeted with a welcome message and instructions.

2. The game will generate a secret number between 0 and 100.

3. You'll be prompted to choose a difficulty level: "Easy," "Medium," "Hard," or "Cheater."

4. Once you've selected a difficulty level, you'll have a limited number of guesses to figure out the secret number.

5. Input your guesses and follow the prompts to receive feedback on your guesses.

6. If you guess the correct number, you win the game. Otherwise, keep guessing until you run out of attempts.


### Difficulty Levels<a name="difficulty-levels"></a>

- **Easy**: You have 8 attempts to guess the secret number.
  
- **Medium**: You have 6 attempts to guess the secret number.
  
- **Hard**: You have 4 attempts to guess the secret number.
  
- **Cheater**: You have unlimited attempts to guess the secret number. (For debugging or practice)

### Code Overview<a name="code-overview"></a>
#### Main Function<a name="main-function"></a>
The Main function is the entry point of the program. It displays a welcome message, generates a secret number, prompts the user to choose a difficulty level, and initiates the guessing loop.

#### Difficulty Levels List<a name="difficulty-levels-list"></a>
The difficultyLevels list holds the maximum number of attempts corresponding to each difficulty level. You can easily modify this list to adjust the game's difficulty.

#### Guessing Loop<a name="guessing-loop"></a>
The program uses a for loop to manage the player's guessing attempts. In each iteration of the loop, the player is prompted to enter a guess. The program then provides feedback on whether the guess is too high or too low. If the player guesses correctly, they win the game. Otherwise, the loop continues until the player runs out of attempts.


