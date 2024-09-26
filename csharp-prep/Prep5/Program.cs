using System;

class Program
{
    static void Main(string[] args)
    {   
        // Welcome to program
        Console.WriteLine("Welcome to Prep 5 activity.");
        Console.WriteLine();

        // Here I call the functions
        DisplayMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squearedNumber = SquareNumber(userNumber);
        DisplayResult(userName, squearedNumber);


    } // End of main function

    // This funtion displays a message
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // This function asks and returns the username
    static string PromptUserName()
    {
        Console.Write("Please enter your username: ");
        string userName = Console.ReadLine();
        
        return userName;
    }

    // This function asks for the favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your username: ");
        int userNumber = int.Parse(Console.ReadLine());
        
        return userNumber;
    }

    // This function squares the users favorite number
    static int SquareNumber(int userNumber)
    {
        int squaredNumber = userNumber * userNumber;

        return squaredNumber;
    }

    //This function displays the results
    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}");
    }

} //End of class program