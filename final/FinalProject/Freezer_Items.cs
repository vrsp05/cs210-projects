// The child class FreezerItems will hold the attributes and methods for a freezer food item
class FreezerItems : FoodItems
{
    // Attributes: NONE for now

    // Constructor
    public FreezerItems()
    {

    } // End of constructor

    // Behaviors
    // This abstract method helps in creating random codes for the items
    public override string UniqueCodeGenerator()
    {
        // This creates a new instance for random
        Random random = new Random();

        // This generates a random number of 4 digis
        int randomCode = random.Next(1000,10000);

        // This builds the code for dry items
        string freezerCode = $"F-{randomCode}";

        // This returns the code
        return freezerCode;

    } // End of method UniqueCodeGenerator
    
} // End of the child class FreezerItems