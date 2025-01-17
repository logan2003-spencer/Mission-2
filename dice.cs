namespace Mission_2;

// 2nd class called Dice
public class Dice
{
    // Variables are set
    private int numOfRolls;
    private Random random;
    // List called rollCounts is made
    private List<int> rollCounts;

    List<int> total = new List<int>();

    // Method
    public Dice(int rolls)
    {
        numOfRolls = rolls;
        // Creates random number
        random = new Random();
        rollCounts = new List<int>(new int[11]);
    }
    
    // Method that chooses a random number between 1 and 6
    public int roll1()
    {
        return random.Next(1, 7);
    }
    
    // Method
    public void getArray()
    {
        // For loop going through the number of rolls from the first class
        for (int i = 0; i < numOfRolls; i++)
        {
            // Goes through each dice and adds them up.
            int die1 = roll1(); 
            int die2 = roll1(); 
            int sum = die1 + die2;      
            rollCounts[sum - 2]++;

        }
        
    }
    
    // Send the list to the first class
    public List<int> GetRollCounts()
    {
        return rollCounts;
    }
    
}