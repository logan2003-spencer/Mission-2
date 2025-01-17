using System;
namespace Mission_2;

// Program main class
internal class Program
{
    // Method 
    public static void Main(string[] args)
    {
        // Print statements for the user and ask how many rolls they want
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        // Make the variables 
        string input = Console.ReadLine();
        int numRolls = int.Parse(input);
        
        // Create an instance for Dice
        Dice dice = new Dice(numRolls); 
        dice.getArray();
        
        // Get the roll counts from Dice class
        List<int> rollCounts = dice.GetRollCounts();
        // Display the count of each sum after all rolls
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls =" + " " + numRolls+ "\n");
        // Loop that goes through the number of the rollCounts
        for (int i = 0; i < rollCounts.Count; i++)
        {
            int sum = i + 2;
            int count = rollCounts[i];
            double percentage = (count / (double)numRolls) * 100;

            // Create a string of asterisks to represent the percentage
            string asterisks = new string('*', (int)percentage);
            Console.WriteLine($"{sum}: {asterisks}");
        }
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");

    }
}





  
    
    

