using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {   
        // Welcome text
        Console.WriteLine("Welcome to Prep 4 activity.");
        Console.WriteLine();

        // Instructions
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Declaring variable and list
        int userInput;
        List<int> numberList = new List<int>();

        // Do while body
        do
        {
            
            Console.Write("Enter a number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                numberList.Add(userInput);
            }


        } while (userInput != 0);

        // This displays the total sum, average and largest number of the list
        Console.WriteLine($"Total sum of the list: {numberList.Sum()}");
        Console.WriteLine($"The average of the list {numberList.Average()}");
        Console.WriteLine($"The largest number of the list: {numberList.Max()}");
    }
}