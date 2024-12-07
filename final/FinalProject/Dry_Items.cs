// The child class DryItems will hold the attributes and methods for a dry food item
class DryItems : FoodItems
{
    // Attributes: NONE for now

    // Constructor
    public DryItems()
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
        string dryCode = $"D-{randomCode}";

        // This returns the code
        return dryCode;

    } // End of method UniqueCodeGenerator
    
} // End of the child class DryItems 