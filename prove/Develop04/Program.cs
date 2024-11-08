using System;
// This is the class for the main program
class Program
{   
    // This is the main function of the program
    static void Main(string[] args)
    {   
        // These variables are for main program usage
        // This variable hold the user main menu decision
        string userSelection;
        // These variables help in couting how many times the user completed and activity
        int breatingLog = 0;
        int listingLog = 0;
        int reflectingLog = 0;

        // This is the do while loop of the menu that runs until the user enters 5
        do
        {   
            // This clears the console
            Console.Clear();

            // This gives a welcome message to the user
            Console.WriteLine();
            Console.WriteLine("Welcome to the Meditation APP!");
            Console.WriteLine();
            
            // This is the menu of the program
            Console.Write(@"MAIN MENU
    Here are our meditation activities:
        1- Breathing Activity
        2- Listing Activity
        3- Reflection Activity
        4- Show Activity Log
        5- Quit
    Please select your preferred meditation activity: ");

            // This assigns the menu option selected
            userSelection = Console.ReadLine();

            // If statements that help in the selection menu
            // If #1: if the user selects the Breathing Activity
            if (userSelection == "1")
            {   
                // The variables are give values to name the activity
                string activityName = "Breathing";
                string activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                
                // This creates a new object for the activity            
                BreathingAct breathing = new BreathingAct(activityName, activityDescription);

                // This starts the activity with its introduction
                breathing.StartMessage();
                // This reads the user input
                int timerTime = int.Parse(Console.ReadLine());

                // This sets the timer
                breathing.SetTimer(timerTime);

                // This tells the user to get ready for the activity
                breathing.GetReady();

                // This starts the breathing activity
                breathing.StartBreathing();

                // This adds one completed activity
                breatingLog += 1;

                // This ends the activity with a brief report
                breathing.EndMessage(activityName);

                // This calls the loading animation again
                breathing.LoadingAnimation();

            } // End of if #1

            // If #2: if the user selects the Listing Activity
            else if (userSelection == "2")
            {
                // The variables are give values to name the activity
                string activityName = "Listing";
                string activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                
                // This creates a new object for the activity            
                ListingAct listing = new ListingAct(activityName, activityDescription);

                // This starts the activity with its introduction
                listing.StartMessage();
                // This reads the user input
                int timerTime = int.Parse(Console.ReadLine());

                // This sets the timer
                listing.SetTimer(timerTime);

                // This tells the user to get ready for the activity
                listing.GetReady();

                // This starts the listing activity
                listing.StartListing();

                // This adds one completed activity
                listingLog += 1;

                // This ends the activity with a brief report
                listing.EndMessage(activityName);

                // This calls the loading animation again
                listing.LoadingAnimation();

            } // End of if #2

            // If #3: if the user selects the Reflecting Activity
            else if (userSelection == "3")
            {
                // The variables are give values to name the activity
                string activityName = "Reflecting";
                string activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                
                // This creates a new object for the activity            
                ReflectingAct reflecting = new ReflectingAct(activityName, activityDescription);

                // This starts the activity with its introduction
                reflecting.StartMessage();
                // This reads the user input
                int timerTime = int.Parse(Console.ReadLine());

                // This sets the timer
                reflecting.SetTimer(timerTime);

                // This tells the user to get ready for the activity
                reflecting.GetReady();

                // This starts the reflection activity
                reflecting.StartReflection();

                // This adds one completed activity
                reflectingLog += 1;

                // This ends the activity with a brief report
                reflecting.EndMessage(activityName);

                // This calls the loading animation
                reflecting.LoadingAnimation();

            } // End of if #3

            // If #4: if the user selects to see how many times the user did an activity
            else if (userSelection == "4")
            {   
                // This empty object to use some activity methods
                Activity activity = new Activity("","");

                // This displays the activity log
                Console.Write($@"
    This shows how many times you have compleated each activity.

    - You completed {breatingLog} Breathing activities.

    - You completed {listingLog} Listing activities.

    - You completed {reflectingLog} Reflecting activities
    
    Loading ");

                // This displays the loading animation
                activity.LoadingAnimation();

            } // End of if #4

            // If #5: if to close the program
            else if (userSelection == "5")
            {   
                // This is the message for closing the app
                Console.WriteLine();
                Console.Write("Closing Meditation APP ");

                // Empty object to use the LoadingAnimation method
                Activity activity = new Activity("","");

                // This ends the program with the loading animation
                activity.LoadingAnimation();

            } // End of if #5
        
        } while (userSelection != "5"); // End of while loop

    } // End of main function

} // End of main class Program