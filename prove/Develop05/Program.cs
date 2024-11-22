using System;
// This is the main class of the progra
class Program
{   
    // This is the main function of the program
    static void Main(string[] args)
    {   

        // This creates an object for each of the classes
        GoalManager manager = new GoalManager();
        SimpleGoal simple = new SimpleGoal();
        EternalGoal eternal = new EternalGoal();
        ChecklistGoal checklist = new ChecklistGoal();

        // These are the variables used in the main progra
        string userSelection;
        int userTotalPoints;
        int userCurrentLevel;

        // This is the welcome message of the program
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Welcome to the Eternal Quest APP!");

        // Do while loop that runs until the user decides to quit
        do
        {
            // This displays the menu
            Console.Write(@$"
LVL: {userCurrentLevel = manager.GetCurrentLVL()}
XP: {userTotalPoints = manager.GetTotalPoints()}

MENU
What would you like to do today?
    1- Create a new goal
    2- List goals
    3- Save goals
    4- Load goal
    5- Record goal progress
    6- Quit APP
Select an option from the menu: ");

        // This reads the user input
        userSelection = Console.ReadLine();

        // If #1: If the user wants to create a new goal
        if (userSelection == "1")
        {   
            // This clears the console
            Console.Clear();

            // This gives the user the type of goals available
            Console.Write(@"
The type of goals are:
    1- Simple Goal
    2- Eternal Goal
    3- Checklist Goal
Please select the type of goal that you want to create: ");

            // This reads the user input
            string userGoalSelection = Console.ReadLine();

            // If #1.1: If the user selects simple goal
            if (userGoalSelection == "1")
            {
                // This method starts the questionnaire
                Console.WriteLine();
                Console.WriteLine("Please answer the questions:");
                simple.AskGoalInfo();

                // This saves the goal into the all goals list
                manager.AddGoals(simple.GetGoalInfo());
                manager.AddGoalsFullInfo(simple.SetGoalsFullInfo());

                // This clears the console
                Console.Clear();

            } // End of if #1.1

            // If #1.2: If the user selects eternal goal
            else if (userGoalSelection == "2")
            {
                // This starts the questionnaire
                Console.WriteLine();
                Console.WriteLine("Please answer the questions:");
                eternal.AskGoalInfo();

                // This saves the goal into the all goals list
                manager.AddGoals(eternal.GetGoalInfo());
                manager.AddGoalsFullInfo(eternal.SetGoalsFullInfo());

                // This clears the console
                Console.Clear();

            } // End of if #1.2

            // If #1.3: If the user selects checklilst goal
            else if (userGoalSelection == "3")
            {
                // This starts the questionnaire
                Console.WriteLine();
                Console.WriteLine("Please answer the questions:");
                checklist.AskGoalInfo();

                // This saves the goal into the all goals list
                manager.AddGoals(checklist.GetGoalInfo());
                manager.AddGoalsFullInfo(checklist.SetGoalsFullInfo());

                // This clears the console
                Console.Clear();

            } // End of if #1.3

        } // End of if #1

        // If #2: If the user wants to list all goals
        else if (userSelection == "2")
        {   
            // This clears the console
            Console.Clear();

            // Extra space and a small message
            Console.WriteLine(@"
Here are all your current goals:");

            // This displays all the goals
            manager.DisplayGoals();

        } // End of if #2

        // If #3: if the user wants to save the goals
        else if (userSelection == "3")
        {   
            // This clears the console
            Console.Clear();

            // This asks the user the name of the file
            Console.WriteLine();
            Console.Write("What is the name of the file? ");
            // This reads the user input
            string fileName = Console.ReadLine();

            // This calls the SaveGoals method from the manager class
            manager.SaveGoals(fileName, userCurrentLevel, userTotalPoints);

        } // End of if #3

        // If #4: if the user wants to load the saved goals
        else if (userSelection == "4")
        {
            // This clears the console
            Console.Clear();

            // This asks the user the name of the file
            Console.WriteLine();
            Console.Write("What is the name of the file? ");
            // This reads the user input
            string fileName = Console.ReadLine();

            // This calls the SaveGoals method from the manager class
            manager.LoadGoals(fileName);

        } // End if of #4

        // If #5: If the user wants to record progress from a goal
        else if (userSelection == "5")
        {   
            // This clears the console
            Console.Clear();

            // This shows the goals to the user displays the goals
            Console.WriteLine();
            Console.WriteLine("Here are your current goals:");
            manager.DisplayGoals();

            // This asks the user which goal wants to record progress of
            Console.WriteLine();
            Console.Write("Enter the goal number: ");

            // This assings the input into a variable and adjust for the 0 based index
            int goalNumber = int.Parse(Console.ReadLine()) - 1;

            // This calls the RecordGoalProgess method to record the progress
            manager.RecordGoalProgress(goalNumber);
            manager.CheckLevelUp();

        } // End of if #5

        // If #6: If the user wants to terminate the progra,
        else if (userSelection == "6")
        {
            // This is the program termination program
            Console.WriteLine(@"
Closing program...
");
        } // End of if #6

        } while (userSelection != "6"); // End of do while loop

    } // End of main function

} // End of main class