using System;

// Main program class
class Program
{   
    // Main function of program
    static void Main(string[] args)
    {   
        // Creating global variables
        string menuInput;

        // Creating instances of the classes
        UserInterface ui = new UserInterface();

        // Starting system message
        Console.WriteLine();
        Console.WriteLine("Starting program... ");

        // Quick loading animation
        ui.LoadingAnimation();

        // This clears the console
        Console.Clear();

        // Do while loop for handling the menu
        do
        {
            // Call the DisplayMenu method to show the menu
            ui.DisplayMenu("food.txt");

            // Reads the user input for the menu and assigns the value
            menuInput = ui.MenuInput();

            // This calls the MenuAction method to perform the menu actions
            ui.MenuActions(menuInput);

        } while (menuInput != "5"); // End of do while loop
        
    } // End of main function

} // End of main program class