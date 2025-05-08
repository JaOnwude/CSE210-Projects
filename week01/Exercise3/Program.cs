using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Console.Write("What is the magic number? ");
        // string magicStringNumber = Console.ReadLine();
        // int magicNumber = int.Parse(magicStringNumber);
        Console.Write("What is your guess? ");
        string userGuess = Console.ReadLine();
        int userGuessNumber = int.Parse(userGuess);

        Random randomNumberGenerator = new Random();
        int randomNumber = randomNumberGenerator.Next(1, 101);
        // Console.WriteLine($"Random Number: {randomNumber}");
        int numberOfGuesses = 1;

         while (userGuessNumber != randomNumber)
        {
            numberOfGuesses++;           
            if (userGuessNumber > randomNumber)
            {
                Console.WriteLine("Lower.");
                Console.Write("What is your guess? ");
                userGuess = Console.ReadLine();
                userGuessNumber = int.Parse(userGuess);
            }
            else
            {
                Console.WriteLine("Higher.");
                Console.Write("What is your guess? ");
                userGuess = Console.ReadLine();
                userGuessNumber = int.Parse(userGuess);
            }
        
        } 
                            
        Console.WriteLine("You guessed it!"); 
        Console.WriteLine($"You made {numberOfGuesses} guesses.");

    //     Console.Write("Do you want to play again (yes, no)? ");
    //     string userResponse = Console.ReadLine();
    // }
}