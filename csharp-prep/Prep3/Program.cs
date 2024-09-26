using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to Prep 3 activity.");
        Console.WriteLine();

        // This code was for part 1 and two.
        //Console.Write("What is the magic number? ");
        //string strInput = Console.ReadLine();

        // Random number generator for part 3
        Random newRandom = new Random();
        int intRandom = newRandom.Next(1,101);

        // Declaring my guess variable
        int intGuess;

        // Using do while loop
        do {

            // Asks the user for the guess
            Console.Write("What is your guess? ");
            intGuess = int.Parse(Console.ReadLine());

            // If statements
            if (intGuess > intRandom)
            {
                Console.WriteLine("Lower");
            }
            else if (intGuess < intRandom)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } while (intGuess != intRandom); // End of do while loop
        
    }
}