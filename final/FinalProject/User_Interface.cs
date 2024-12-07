// This class will handle the most of the actions performed by the user in the menu
using System.Net;
using System.Reflection.Metadata.Ecma335;

class UserInterface
{
    // Attributes
    private bool _isRunning;
    // This creates an instance for the FoodStorageManager class
    FoodStorageManager _fsms = new FoodStorageManager();
    // This creates an instances for the DryItems and FreezerItems classes from the FoodItem class
    FoodItems _dryItems = new DryItems();
    // This variable help in checking if the info was already loaded
    private bool _isLoaded;

    // Constructors
    public UserInterface()
    {

    } // End of constructor

    // Behaviors
    
    // This method displays the menu to the user
    public void DisplayMenu(string fileName)
    {   
        // This calls the method that helps automatically loading all data
        LoadingSequence(fileName);

        // This prints the menu
        Console.Write(@"
Welcome to the Food Storage Management System (FSMS)

MAIN MENU
Here are your FSMS options:
 1- Add a food item
 2- Remove a food item
 3- View my items
 4- Save my list
 5- Quit program
Please select from the menu: ");

    } // End of DisplayMenu method

    // This method will handle the user input for the menu
    public string MenuInput()
    {
        // This reads the user input
        string menuInput = Console.ReadLine();

        // This returns the input
        return menuInput;
        
    } // End of method MenuInput

    // This method will handle the decisions of the user
    public void MenuActions(string input)
    {   
        // If #1: If the user selects to add an item
        if (input == "1")
        {   
            // This starts the questionnaire to help create the new item
            Console.WriteLine();
            Console.WriteLine("Please answer the following questions:");

            // This is the questionnaire to build the new item, conversion is done in the respective lines
            Console.Write("What is the name of the item? ");
            string name = MenuInput();

            Console.Write("What is the type of the item (meat, vegetable, bread or rice)? ");
            string type = MenuInput();

            Console.Write("What is the expiration date of the item (MM/dd/yyyy)? ");
            string expirationDate = MenuInput();

            Console.Write("What is the price of the item? ");
            float price = float.Parse(MenuInput()); // Conversion from string to float

            Console.Write("How many items are you adding to storage? ");
            int quantity = int.Parse(MenuInput()); // Conversion from string to int

            Console.Write("What is the storage location for the itme (freezer or dry)? ");
            string location = MenuInput();

            // This helps in deciding which type of code is needed
            string code = _fsms.CodeTypeDecider(location);

            // This builds the item's information
            string foodItem = _dryItems.BuildFoodItem(name, type, expirationDate, price, quantity, location, code);

            // This is a adding message
            Console.WriteLine("Adding... ");

            // Quick animation to close this adding session
            LoadingAnimation();

            // This adds the item into the list
            _fsms.AddFoodItem(foodItem);

            // This tells the user the item was added
            Console.WriteLine();
            Console.WriteLine($"The food item '{name}' was added successfully.");
            Console.WriteLine();

            // This is a adding message
            Console.WriteLine("Loading... ");

            // Quick animation to close this adding session
            LoadingAnimation();

            // This clears the console
            Console.Clear();

        } // End of if #1

        // If #2: If the user selects to delete an item
        else if (input == "2")
        {
            // This asks the user what is the code of the food item and reads the input
            Console.WriteLine();
            Console.Write("What is the code if the food item? ");
            string code = MenuInput();

            // This is a adding message
            Console.WriteLine("Removing... ");

            // Loading animation
            LoadingAnimation();

            // This calls the remove item method
            _fsms.RemoveFoodItem(code);

            // This is a adding message
            Console.WriteLine("Closing... ");

            // Quick animation to close the removing session
            LoadingAnimation();

            // This clears the console
            Console.Clear();

        } // End of if #2

        // If #3: if the user wanrs to view all the items
        else if (input == "3")
        {   
            // This is the loading message
            Console.WriteLine();
            Console.WriteLine("Displaying items...");

            // Displays the quick animation
            LoadingAnimation();

            // This clears the console
            Console.Clear();

            // This presents the items
            Console.WriteLine();
            Console.WriteLine("These are your current stored items:");

            // This displays all the items
            _fsms.DisplayAllItems();

        } // End of if #3

        // If #4: if the user wants to save the list
        else if (input == "4")
        {   
            // This asks the user the name of the file and reads the input
            Console.WriteLine();
            Console.Write("What is the name of the file? ");
            string fileName = MenuInput();

            // This is a adding message
            Console.WriteLine("Saving... ");

            // Displays the quick animation
            LoadingAnimation();

            // This calls the method that saves the file
            _fsms.SaveFoodItems(fileName);
           
            // This is a adding message
            Console.WriteLine("Closing... ");

            // Quick animation to close the saving session
            LoadingAnimation();

            // This clears the console
            Console.Clear();

        } // End of if #4

        // If #5: if the user wants to quit the program
        else if (input == "5")
        {   
            // This gives a nice goodbye message
            Console.WriteLine(@"
Goodbye, and have a nice day!
");
        // This tells the user that program is closing
        Console.WriteLine("Quiting program...");

        // Displays the quick animation
        LoadingAnimation();

        } // End of if #5

    } // End of MenuActions

    // This is the loading animation method
    public void LoadingAnimation()
    {
        // Time delay in milliseconds between each step of the animation
        int delay = 250;

        // Repeat the sequence a few times
        for (int i = 0; i < 2; i++)
        {
            // Step 1: Show one asterisk
            Console.Write("*");
            System.Threading.Thread.Sleep(delay);

            // Step 2: Show two asterisks
            Console.Write("*");
            System.Threading.Thread.Sleep(delay);

            // Step 3: Show three asterisks
            Console.Write("*");
            System.Threading.Thread.Sleep(delay);

            // Step 4: Show four asterisks
            Console.Write("*");
            System.Threading.Thread.Sleep(delay);

            // Step 5: Show five asterisks
            Console.Write("*");
            System.Threading.Thread.Sleep(delay);

            // Step 4: Remove asterisks one by one
            Console.Write("\b \b"); // Remove the last asterisk
            System.Threading.Thread.Sleep(delay);

            Console.Write("\b \b"); // Remove the fourth asterisk
            System.Threading.Thread.Sleep(delay);

            Console.Write("\b \b"); // Remove the third asterisk
            System.Threading.Thread.Sleep(delay);

            Console.Write("\b \b"); // Remove the second asterisk
            System.Threading.Thread.Sleep(delay);

            Console.Write("\b \b"); // Remove the first asterisk
            System.Threading.Thread.Sleep(delay);

        } // End of for loop

    } // End of LoadingAnimation method

    // This method will help in loading the information into the file
    public void LoadingSequence(string fileName)
    {      
        // If# 1: Checks if the file was already loaded
        if (_isLoaded == false)
        {   
            // This calls the method that loads all date
            _fsms.LoadFoodItems(fileName);

            // Marks the file as loaded to avoid loading repeatedly
            _isLoaded = true;

        } // End of if #1

        // If #2: Checks and tells the the user that the data was loadedn
        else if (_isLoaded == true)
        {   
            // Debuggin message that helps marking that the file was uploaded
            Console.WriteLine("File is already loaded");

        } // End of if #2

    } // End of method LoadingSequence

} // End of class UserInterface