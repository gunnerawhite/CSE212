using System.Diagnostics;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1 create a list of doubles with the size of length
        double[] multiples = new double[length];
        // Step 2 Use a loop to fill the array with numbers
        for (int i = 0; i < length; ++i){
            // Step 3 find the multiple and assign it to the array
            multiples[i] = number * (i + 1);
        }
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Step 5 return the array

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3, 
    /// then the list after the function runs should be List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.
    /// The value of amount will be in the range of 1 to data.Count, inclusive.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1 Make sure the input is good
        if (data == null || data.Count == 0 || amount < 1 || amount > data.Count)
        {
            return; // Invalid input; nothing to do
        }

        // Step 2: Normalize the amount to avoid unnecessary rotations
        amount = amount % data.Count;

        // Step 3: Create a temporary list to hold the rotated values
        List<int> rotated = new List<int>(data.Count);

        // Step 4: Add the last 'amount' elements to the new list first
        rotated.AddRange(data.GetRange(data.Count - amount, amount));

        // Step 5: Add the remaining elements
        rotated.AddRange(data.GetRange(0, data.Count - amount));

        // Step 6: Clear the original list and add the rotated elements back
        data.Clear();
        data.AddRange(rotated);
    }
}
