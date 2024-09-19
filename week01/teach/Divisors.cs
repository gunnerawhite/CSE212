public static class Divisors {
    /// <summary>
    /// Entry point for the Divisors class
    /// </summary>
    public static void Run() {
        List<int> list = FindDivisors(80);
        Console.WriteLine("<List>{" + string.Join(", ", list) + "}"); // <List>{1, 2, 4, 5, 8, 10, 16, 20, 40}
        List<int> list1 = FindDivisors(79);
        Console.WriteLine("<List>{" + string.Join(", ", list1) + "}"); // <List>{1}
    }

    /// <summary>
    /// Create a list of all divisors for a number including 1
    /// and excluding the number itself. Modulo will be used
    /// to test divisibility.
    /// </summary>
    /// <param name="number">The number to find the divisor</param>
    /// <returns>List of divisors</returns>
    private static List<int> FindDivisors(int number) {
        // Step1 create a list to hold the divisors
        List<int> results = new List<int>();
        // Step 2: Use a for loop to find divisors
        for (int i = 1; i < number; i++){
            // Step 3: Check if 'i' is a divisor of 'number'
            if (number % i == 0)
            {
                // Step 4: Add the divisor to the list
                results.Add(i);
            }
        }
        return results;
    }
}