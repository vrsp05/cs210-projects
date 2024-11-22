// GoalCLass will be the parent class for all type of goals.
abstract class GoalClass
{
    // Attributes
    // This variable will hold the name of the goal
    protected string _goalName;
    // This variable will hold the description of the goal
    protected string _goalDescription;
    // This variable will hold the reward points given to the user after completing a goal
    protected int _rewardPoints;

    // Constructors
    public GoalClass()
    {

    } // End of constructor

    // Behaviors
    // This method helps with building and returning the goal info
    public abstract string GetGoalInfo(); // End of GetGoalInfo method

    // This method assigns values to the private attributes
    public void SetGoalInfo(string name, string description, int points)
    {
        // This assigns the values into the corresponding variables
        _goalName = name;
        _goalDescription = description;
        _rewardPoints = points;

    } // End of SetGoalInfo method
    
    // This abstract method helps with displaying the questionnaire
    public abstract void AskGoalInfo(); 

    // This abstract method helps with formatting in how to save the goals
    public abstract string SetGoalsFullInfo();

} // End of parent class GoalClass