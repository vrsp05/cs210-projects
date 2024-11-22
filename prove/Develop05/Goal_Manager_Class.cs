// This class will help with managing the goal's information
using System.Formats.Asn1;

class GoalManager
{
    // Attributes
    // This variable holds the total points that the user has
    private int _totalPoints;
    // This list will hold all the goals
    private List<string> _allGoals = new List<string>();
    // This list helps with storing the full info of goals
    List<string> _goalsFullInfo = new List<string>();
    // This helps tracking the user's lvl
    private int _userLevel = 1;

    // Constructors

    // Behaviors
    // This method adds goals to the list
    public void AddGoals(string goal)
    {   
        // This adds the goal into the list
        _allGoals.Add(goal);

    } // End of AddGoals method

        // This method adds goals to the list
    public void AddGoalsFullInfo(string goalInfo)
    {   
        // This adds the goal into the list
        _goalsFullInfo.Add(goalInfo);

    } // End of AddGoals method
    
    // This method displays the goals
    public void DisplayGoals()
    {   
        // This to display the lists organized with numbers
        int goalNumber = 1;

        // Foreach loop that displays all the goals
        foreach (string goal in _allGoals)
        {
            // This displays the goal
            Console.WriteLine($"{goalNumber}. {goal}");

            // This adds one to the goalNumber
            goalNumber++;

        } // End of foreach

    } // End of DisplayGoals

    // This method helps with saving the goals
    public void SaveGoals(string fileName, int lvl, int points)
    {   
        // This writes a new file
        using (StreamWriter writer = new StreamWriter(fileName))
        {   
            // This writes the level of the user
            writer.WriteLine($"UserLVL:{lvl}");

            // This writes the current points of the user
            writer.WriteLine($"UserSavedPoints:{points}");

            // Foreach that writes each goal
            foreach (string goal in _goalsFullInfo)
            {   
                // This writes the goal
                writer.WriteLine(goal);

            } // End of foreach

        } // End of writer

        // Displays a completed message
        Console.WriteLine();
        Console.WriteLine("Goals saved successfully!");

    } // End of SaveGoals method

    // This method will help with loading the file content
    public void LoadGoals(string filePath)
    {   
        // This pulls the file content and stores it in an array
        string[] lines = System.IO.File.ReadAllLines(filePath);

            // This splits the first line to get the user level
            string[] levelParts = lines[0].Split(':');

            // This confirms if the first line is about the user lvl
            if (levelParts[0] == "UserLVL")
            {   
                // This assigns the value
                _userLevel = int.Parse(levelParts[1]);

                // This displays a message telling the user that the level was added
                Console.WriteLine();
                Console.WriteLine($"User Level Loaded: {_userLevel}");

            } // End of if

            // This splits the second line to fid the saved points
            string[] pointsParts = lines[1].Split(':');

            // This confirms if the second line is about the user lvl
            if (pointsParts[0] == "UserSavedPoints")
            {   
                // This assigns the value
                _totalPoints = int.Parse(pointsParts[1]);

                // This displays the total points loaded
                Console.WriteLine($"User Points Loaded: {_totalPoints}");
            
            } // End of if

        // This foreach loop runs until there are no more lines
        for (int i = 2; i < lines.Length; i++)
        {   
            // These arrays help to sparate the values from the file and then store them
            string line = lines[i];
            string[] parts = line.Split(':');
            string goalType = parts[0];
            string[] goalsDetails = parts[1].Split(',');

            // This assigns a variable to the array values
            string goalName = goalsDetails[0];
            string goalDescription = goalsDetails[1];
            string goalsReward = goalsDetails[2];

            // If #1: Checks if the goal type is "SimpleGoal"
            if (goalType == "SimpleGoal")
            {   
                // This creates a new instance from the child class simpleGoal
                SimpleGoal simple = new SimpleGoal();

                // This assigns the value and converts it
                bool completed = bool.Parse(goalsDetails[3]);

                // This "loads" the goal's information
                simple.SetGoalInfo(goalName, goalDescription, int.Parse(goalsReward));
                
                // This saves the current status of the goal
                simple.SetCompletion(completed);

                // This adds the goal back into the list
                _allGoals.Add(simple.GetGoalInfo());
                _goalsFullInfo.Add(simple.SetGoalsFullInfo());

            } // End of if #1

            // If #2: Checks if the goal type is "ChecklistGoal"
            else if (goalType == "ChecklistGoal")
            {   
                // This creates a new instance from the child class ChecklistGoal
                ChecklistGoal checklist = new ChecklistGoal();

                // This assigns the values
                int bonus = int.Parse(goalsDetails[3]);
                int timesToComplete = int.Parse(goalsDetails[4]);
                int timesCompleted = int.Parse(goalsDetails[5]);
                
                // If #2.1L Checks if the goal is completed
                if (timesCompleted == timesToComplete)
                {   
                    // The value is assigned to true
                    bool isCompleted = true;

                    // This "loads" the exclusive information of the goal ty checklist
                    checklist.SetChecklistDetails(
                        bonus,
                        timesToComplete,
                        timesCompleted,
                        isCompleted
                    );

                } // End of if #2.1

                // Else if the goal is not yet completed
                else
                {   
                    // The value is assigned to false
                    bool isCompleted = false;

                    // This "loads" the exclusive information of the goal ty checklist
                    checklist.SetChecklistDetails(
                        bonus,
                        timesToComplete,
                        timesCompleted,
                        isCompleted
                    );

                } // End of false

                // This "loads" the goal's information
                checklist.SetGoalInfo(goalName, goalDescription, int.Parse(goalsReward));

                // This adds the goal back into the list
                _allGoals.Add(checklist.GetGoalInfo());
                _goalsFullInfo.Add(checklist.SetGoalsFullInfo());

            } // End of if #2

            // If #3: Checks if the goal type is "EternalGoal"
            else if (goalType == "EternalGoal")
            {   
                // This creates a new instance from the child class EternalGoal
                EternalGoal eternal = new EternalGoal();

                // This "loads" the goal's information
                eternal.SetGoalInfo(goalName, goalDescription, int.Parse(goalsReward));

                // This adds the goal back into the list
                _allGoals.Add(eternal.GetGoalInfo());
                _goalsFullInfo.Add(eternal.SetGoalsFullInfo());

            } // End of if #3

        } // End of foreach loop

        // This displays a nice message confirming that the goals have been loaded
        Console.WriteLine("Goals loaded successfully.");

    } // End of LoadGoals method

    // This method helps with recording the progress of the selected goal
    public void RecordGoalProgress(int goalIndex)
    {
        // RecordGoalProgress main if. It checks if the goal selected by the user is a valid number
        if (goalIndex >= 0 && goalIndex < _allGoals.Count)
        {
            // Get the goal string and split it into its components
            string fullGoalInfo = _goalsFullInfo[goalIndex];

            // This splist the string by type
            string[] goalsInfoParts = fullGoalInfo.Split(':');

            // This assigns the first part to a variable which is the goalType
            string goalType = goalsInfoParts[0];

            // This splits the goal info
            string[] goalsDetails = goalsInfoParts[1].Split(',');

            // This assigns a variable to the array values
            string goalName = goalsDetails[0];
            string goalDescription = goalsDetails[1];
            string goalsReward = goalsDetails[2];

            // If #1 this if serves for simple type goals
            if (goalType == "SimpleGoal")
            {

                // If #1.1 that updates the completion status
                if (goalsDetails[3] == "False")
                {   
                    // This marks the simple goal as completed
                    goalsDetails[3] = "True";

                    // This displays a message telling the user that the goal was completed
                    Console.WriteLine();
                    Console.WriteLine($"Goal \"{goalName}\" marked as completed! You earned {goalsReward} points.");
                    
                    // This adds the points into the total points accumulated by the user
                    _totalPoints += int.Parse(goalsReward);
                    
                    // This updates the status of the goal
                    _allGoals[goalIndex] = $"[X] {goalName} ({goalDescription})";

                } // End of if #1.1

                // Else that tells the user if the goal was already completed
                else
                {   
                    // This displays the message
                    Console.WriteLine();
                    Console.WriteLine($"Goal \"{goalName}\" is already completed.");

                } // End of else

            } // End of if #1.1

            // If #1.2 serves for eternal type goals
            else if (goalType == "EternalGoal")
            {
                // This tells the user progress was made but it never marks it as completed
                Console.WriteLine();
                Console.WriteLine($"Progress recorded for goal \"{goalName}\"! You earned {goalsReward} points.");

                // This adds the points into the total points
                _totalPoints += int.Parse(goalsReward);
                
                // This updates the goal
                _allGoals[goalIndex] = $"[ ] {goalName} ({goalDescription})";

            } // End of if #1.2

            // If #1.3 serves for checklist type goals
            else if (goalType == "ChecklistGoal")
            {   
                // This assigns the values that help in checking the progress of the checklist goal
                int timesCompleted = int.Parse(goalsDetails[5]);
                int timesToComplete = int.Parse(goalsDetails[4]);
                
                // If #1.3.1 that helps in checking if the goal has not been completed
                if (timesCompleted < timesToComplete)
                {   
                    // This marks the progress of the goal
                    timesCompleted++;

                    // This converts back to string for a smoother transition when saving
                    goalsDetails[4] = timesToComplete.ToString();
                    goalsDetails[5] = timesCompleted.ToString();

                    // If #1.3.1.1 that executes if the user still hasn't reached the goal
                    if (timesCompleted < timesToComplete) {
                        // This tells the user that progress was made
                        Console.WriteLine();
                        Console.WriteLine($"Progress recorded for goal \"{goalName}\"! You earned {goalsReward} points.");

                        // This adds the points into the total amount of points
                        _totalPoints += int.Parse(goalsReward);
                        
                        // This updates the goal back into the list
                        _allGoals[goalIndex] = $"[ ] {goalName} ({goalDescription}) -- Currently completed: {timesCompleted}/{timesToComplete}";
                    
                    } // End of if #1.3.1.1

                    // If #1.3.1.2 that executes once the user reaches the goal
                    else if (timesCompleted == timesToComplete)
                    {
                        // This adds the reward and the bonus
                        int bonusPoints = int.Parse(goalsReward) + int.Parse(goalsDetails[3]); 

                        // This displays a message to the user
                        Console.WriteLine();
                        Console.WriteLine($"Congratulations! Goal \"{goalName}\" completed! You earned a bonus of {bonusPoints} points.");

                        // This adds the reward into the total amount
                        _totalPoints += bonusPoints;

                        // This updates the goal back into the list
                        _allGoals[goalIndex] = $"[X] {goalName} ({goalDescription}) -- Currently completed: {timesCompleted}/{timesToComplete}";
                    
                    } // End of if #1.3.1.1

                } // End of if #1.3.1

                // Else if that tells the user that the list is already completed
                else
                {   
                    // This displays the message
                    Console.WriteLine($"Goal \"{goalName}\" is already completed.");
                
                } // End of else

            } // End if if #1.3

            // This updates the goals full info back into the list
            _goalsFullInfo[goalIndex] = $"{goalType}:{string.Join(',', goalsDetails)}";

        } // End of RecordGoalProgress main if

        // Else that executes when the user inputs a valid number
        else
        {   
            // Error message
            Console.WriteLine("Invalid goal number.");

        } // End of else

    } // End of RecordProgressMethod

    // This method returns the total points
    public int GetTotalPoints()
    {
        // This returns the total points
        return _totalPoints;

    } // End of GetTotalPoints method

    // This method returns the total points
    public int GetCurrentLVL()
    {
        // This returns the total points
        return _userLevel;

    } // End of GetTotalPoints method

    // This method helps with setting a new lvl for the user
    public void CheckLevelUp()
    {
        // This calculates the points required for the next level
        int pointsNeeded = (_userLevel * (_userLevel + 1) * 500);

        // While loop that checks if user has enough points
        while (_totalPoints >= pointsNeeded && _userLevel < 100)
        {   
            // This increments the lvl of the user
            _userLevel++;

            // This displays a message
            Console.WriteLine();
            Console.WriteLine($"Congratulations! You leveled up to LVL {_userLevel}!");

            // This updates the required amount for the next lvl
            pointsNeeded = (_userLevel * (_userLevel + 1) * 500);

        } // End of while loop
    
    } // End of CheckLevelUp method

} // End of class GoalManager