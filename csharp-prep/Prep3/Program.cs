using System;

class Program
{


    static void Main(string[] args)
    {
        // Random randomGenerator = new Random();
        // int MagicNum = randomGenerator.Next(1, 11);


        // Takes input to set users magic number 
        Console.Write("What is the magic number? ");
        string magicNumInput = Console.ReadLine();
        int magicNum = int.Parse(magicNumInput);

        // Brings scope of guess outside of the do while loop
        int guess;

        // Loops until user guesses the right number.
        do
        {
            // Takes input for users guess 
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);

            // Checks if user guess is too hight ot to low 
            if (magicNum < guess)
            {
                Console.WriteLine("Lower");

            }
            else if (magicNum > guess)
            {
                Console.WriteLine("Higher");

            }
            else
            {
                Console.WriteLine("You guessed it!");

            }
        } while (guess != magicNum);

    }
}